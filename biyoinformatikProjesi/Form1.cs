using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biyoinformatikProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openfiledialog = new OpenFileDialog();
        public string sequence1TxtPath, sequence2TxtPath, txt1String, txt2String, combination1,combination2;
        public int txt1Count, txt2Count, match, missmatch, gap, diagonal,score;     
        public int[] valuesLastState = new int[3];

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGap.Text = "-2";
            txtMatch.Text = "1";
            txtMissmatch.Text = "-1";
        }

        private void browseTxt1_Click(object sender, EventArgs e)
        {
            SelectFile();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                txt1path.Text = openfiledialog.FileName;
                sequence1TxtPath = openfiledialog.FileName.ToString();
            }
        }

        private void browseTxt2_Click(object sender, EventArgs e)
        {
            SelectFile();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                txt2path.Text = openfiledialog.FileName;
                sequence2TxtPath = openfiledialog.FileName.ToString();
            }
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            BtnDoldurDriverMetod();
        }


        //*********************************** ELLE YAZILAN FONKSİYONLAR ***********************/

        //dosya seçmek için gereken metot 
        public void SelectFile()
        {
                   
            openfiledialog.RestoreDirectory = true;
            openfiledialog.Title = "Browse Txt Sequence";
            openfiledialog.DefaultExt = "txt";
            openfiledialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openfiledialog.CheckFileExists = true;
            openfiledialog.CheckPathExists = true;
        }       

        //Txt okumak 
        public void Read()
        {           
            using (StreamReader file = new StreamReader(sequence1TxtPath))
            {
                int counter = 0;
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        txt1Count = int.Parse(line);
                    }
                    else
                    {
                        txt1String = line;
                    }
                    counter++;
                }
                file.Close();
            }
            using (StreamReader file = new StreamReader(sequence2TxtPath))
            {
                int counter = 0;
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        txt2Count = int.Parse(line);
                    }
                    else
                    {
                        txt2String = line;
                    }
                    counter++;
                }
                file.Close();
            }
        }

        //satırları nükleotitler ile dolduran metot
        public void fillGridViewColomn()
        {          
            dataGridView1.AutoGenerateColumns = false;      
            dataGridView1.ColumnCount = txt1Count+2;                     
            string[] txt1Karakterleri = new string[txt1String.Length];
            for (int i = 0; i < txt1String.Length; i++)
            {
                txt1Karakterleri[i] = txt1String[i].ToString();
            }           
            for (int i = 0; i < txt1Karakterleri.Length; i++)
            {
                dataGridView1.Columns[i+1].Name = txt1Karakterleri[i].ToString();
                dataGridView1.Columns[i+1].HeaderText = txt1Karakterleri[i].ToString();
                dataGridView1.Columns[i+1].DataPropertyName = txt1Karakterleri[i].ToString();
            }

        }

        //sütunları nükleotitler ile dolduran metot
        public void fillGridViewRow()
        {           
            string[] txt2Karakterleri = new string[txt2String.Length];
            for (int i = 0; i < txt2String.Length; i++)
            {
                txt2Karakterleri[i] = txt2String[i].ToString();
            }
            for (int i = 0; i < txt2Karakterleri.Length+1; i++)
            {
                if (i == 0)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = 0;
                }
                else
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].HeaderCell.Value = txt2Karakterleri[i - 1].ToString();
                }
                
            }
           
            
        }
    
        //satır ve sütunları dolduran fonksiyonları çağıran fonksiyon
        public void BtnDoldurDriverMetod()
        {
            dataGridView1.Columns.Clear();
            match = int.Parse(txtMatch.Text);
            missmatch = int.Parse(txtMissmatch.Text);
            gap = int.Parse(txtGap.Text);
            Stopwatch calculate = new Stopwatch();
            calculate.Start();
            Read();
            fillGridViewColomn();
            fillGridViewRow();
            fillGap();          
            fillCells();          
            traceback();
            
            calculate.Stop();
            TimeSpan runtime = calculate.Elapsed;
            string Sonuc = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",runtime.Hours, runtime.Minutes, runtime.Seconds, runtime.Milliseconds);
            txtCalismaSuresi.Text = Sonuc;
            writeTxt();
        }

        //gap değerine göre satır ve sütunları dolduran fonksiyon
        public void fillGap()
        {               
            for (int i = 1; i < txt1Count+1; i++)
            {               
                dataGridView1.Rows[0].Cells[i].Value = gap + int.Parse((dataGridView1.Rows[0].Cells[i-1].Value).ToString());
            }
            for (int i = 1; i < txt2Count+1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = gap + int.Parse((dataGridView1.Rows[i-1].Cells[0].Value).ToString());
            }           
        }

        //soldan gelen degeri hesaplayan metot
        public int fromLeft(int rowIndex, int cellIndex)
        {
            return (int.Parse(dataGridView1.Rows[rowIndex].Cells[cellIndex-1].Value.ToString()));
        }

        //yukarıdan gelen degeri hesaplayan metot
        public int fromUp(int rowIndex, int cellIndex)
        {
            return (int.Parse(dataGridView1.Rows[rowIndex-1].Cells[cellIndex].Value.ToString()));
        }

        //çaprazdan gelen değeri hesaplayan metot
         public int Diagonal(int rowIndex, int cellIndex)
         {
            diagonal = returnDiagonalValue(rowIndex, cellIndex);
             if (dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString().Equals(dataGridView1.Columns[cellIndex].HeaderText.ToString()))
             {
                 diagonal = diagonal + match;
             }
             else
             {
                 diagonal = diagonal + missmatch;
             }
             return diagonal;
         }

        //diagonali döndüren fonksiyon
        public int returnDiagonalValue(int rowIndex, int cellIndex)
        {
            return int.Parse(dataGridView1.Rows[rowIndex - 1].Cells[cellIndex - 1].Value.ToString());      
        }

        //son durumu belirleyen metot
        public int lastState(int rowIndex, int cellIndex)
        {
            valuesLastState[0] = fromLeft(rowIndex, cellIndex)+ gap;
            valuesLastState[1] = fromUp(rowIndex, cellIndex)+ gap;
            valuesLastState[2] = Diagonal(rowIndex, cellIndex);
            int maxValue = returnMaxValue(valuesLastState);
            return maxValue;
        }

        //valueslaststate dizisindeki 3 değeri sürekli tekrar doldurup geri döndüren metot
        public int[] returnValuesLastStateArray(int rowIndex, int cellIndex)
        {
            valuesLastState[0] = fromLeft(rowIndex, cellIndex);
            valuesLastState[1] = fromUp(rowIndex, cellIndex);
            valuesLastState[2] = returnDiagonalValue(rowIndex, cellIndex);
            return valuesLastState;
        }

        //max değeri dönen fonksiyon
        public int returnMaxValue(int[] valuesLastState)
        {
            return valuesLastState.Max();
        }

        //hücreleri dolduran metot
        public void fillCells()
        {
            for (int rowI = 1; rowI < txt1Count+1; rowI++)
            {
                for (int cellI = 1; cellI < txt2Count+1; cellI++)
                {
                    dataGridView1.Rows[rowI].Cells[cellI].Value= lastState(rowI, cellI);
                }
            }
        }

        /************* Buradan aşağısı traceback adımlarını içerir *******************/

        /*
         * 
         * NOT
         * Burada eğer headerlar yani nükletitler
         * eşleşirse diagonal ilerleyeceğiz.
         * eşleşmez ise:
         * diagonal = matris[row-1][cell-1]
         * up = matris[row-1][cell]
         * left = matris[row][cell-1]
         * değerlerini diziye atıp bunlar arasından en büyüğü bulup yeni konum olarak
         * bu noktayı belirleyeceğiz.
         * bu sırada:
         * eğer sola gittiysek gap yani "-" ekleyeceğiz
         * eğer şu an bulunduğumuz indis diagonal değerinden küçükse missmatch
         * eğer şu an bulunduğumuz indis diagonal değerinden büyükse match
         * matris üzerinde gezinmek için bir adet index veya cursor gibi hareket eden araca ihtiyacımız var
         *
         */

        public void traceback()
        {
            score = 0;
            int rowIndex = txt2Count;
            int cellIndex = txt1Count;
            while (rowIndex != -1 && cellIndex != -1)
            {

                if (rowIndex == 0 )
                {
                    dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                    combination1 = combination1 + dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString();
                    combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderText.ToString();
                    combination1 = combination1 + "--";
                    score = score + gap;
                    break;
                }
                if (cellIndex == 0)
                {
                    dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                    combination1 = combination1 + dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString();
                    combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderCell.Value.ToString();
                    combination2 = combination2 + "--";
                    score = score + gap;
                    break;
                }
                valuesLastState = returnValuesLastStateArray(rowIndex, cellIndex);
                int maxValueFromValuesLastState = returnMaxValue(valuesLastState);                
                if ((dataGridView1.Columns[cellIndex].HeaderText.ToString().Equals(dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString())))
                {
                    combination1 = combination1 + dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString();
                    combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderCell.Value.ToString();
                    dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                    rowIndex--;
                    cellIndex--;
                    score = score + match;
                }
                else
                {
                    if (returnDiagonalValue(rowIndex, cellIndex) == maxValueFromValuesLastState)
                    {
                        //çapraza git                    
                        combination1 = combination1 + dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString();
                        combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderCell.Value.ToString();
                        dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                        rowIndex--;
                        cellIndex--;
                        score = score + missmatch;
                        
                    }
                    else if (fromLeft(rowIndex, cellIndex) == maxValueFromValuesLastState)
                    {
                        //sola git
                        if (cellIndex == 0)
                        {
                            combination1 = combination1 + dataGridView1.Rows[rowIndex].HeaderCell.Value.ToString();
                            combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderText.ToString();
                            dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                            score = score + missmatch;
                        }
                        else
                        {
                            combination1 = combination1 + "--";
                            combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderCell.Value.ToString();
                            dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                            cellIndex = cellIndex - 1;
                            score = score + gap;
                        }
                       
                    }
                    else
                    {
                        //yukarı git
                        combination1 = combination1 + "--";
                        combination2 = combination2 + dataGridView1.Columns[cellIndex].HeaderText.ToString();
                        dataGridView1.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                        rowIndex = rowIndex - 1;
                        score = score + gap;
                    }
                }              
               
            }
          
        }

        /******************** Performans ve sonuç değerlerinin yazıldığı kısım ************/

        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        
        public void writeTxt()
        {
            txtRichCombination.Text = "Result " + "\n"
                + Reverse(combination1) + "\n" 
                + Reverse(combination2) + "\n"
                + "score = " + score.ToString() + "\n"
                + "seq 1 " + txt1String + "\n"
                + "seq 2 " + txt2String;     
        }

    }
}
