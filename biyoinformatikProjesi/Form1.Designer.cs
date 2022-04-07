
namespace biyoinformatikProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseTxt1 = new System.Windows.Forms.Button();
            this.browseTxt2 = new System.Windows.Forms.Button();
            this.txt1path = new System.Windows.Forms.TextBox();
            this.txt2path = new System.Windows.Forms.TextBox();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.txtMissmatch = new System.Windows.Forms.TextBox();
            this.txtGap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropGrp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalismaSuresi = new System.Windows.Forms.TextBox();
            this.txtRichCombination = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPropGrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // browseTxt1
            // 
            this.browseTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.browseTxt1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.browseTxt1.Location = new System.Drawing.Point(315, 19);
            this.browseTxt1.Name = "browseTxt1";
            this.browseTxt1.Size = new System.Drawing.Size(75, 32);
            this.browseTxt1.TabIndex = 0;
            this.browseTxt1.Text = "browse";
            this.browseTxt1.UseVisualStyleBackColor = false;
            this.browseTxt1.Click += new System.EventHandler(this.browseTxt1_Click);
            // 
            // browseTxt2
            // 
            this.browseTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.browseTxt2.Location = new System.Drawing.Point(315, 68);
            this.browseTxt2.Name = "browseTxt2";
            this.browseTxt2.Size = new System.Drawing.Size(75, 32);
            this.browseTxt2.TabIndex = 1;
            this.browseTxt2.Text = "browse";
            this.browseTxt2.UseVisualStyleBackColor = false;
            this.browseTxt2.Click += new System.EventHandler(this.browseTxt2_Click);
            // 
            // txt1path
            // 
            this.txt1path.Location = new System.Drawing.Point(79, 30);
            this.txt1path.Name = "txt1path";
            this.txt1path.ReadOnly = true;
            this.txt1path.Size = new System.Drawing.Size(209, 20);
            this.txt1path.TabIndex = 2;
            // 
            // txt2path
            // 
            this.txt2path.Location = new System.Drawing.Point(79, 80);
            this.txt2path.Name = "txt2path";
            this.txt2path.ReadOnly = true;
            this.txt2path.Size = new System.Drawing.Size(209, 20);
            this.txt2path.TabIndex = 3;
            // 
            // txtMatch
            // 
            this.txtMatch.Location = new System.Drawing.Point(150, 21);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.Size = new System.Drawing.Size(239, 20);
            this.txtMatch.TabIndex = 4;
            // 
            // txtMissmatch
            // 
            this.txtMissmatch.Location = new System.Drawing.Point(150, 61);
            this.txtMissmatch.Name = "txtMissmatch";
            this.txtMissmatch.Size = new System.Drawing.Size(239, 20);
            this.txtMissmatch.TabIndex = 5;
            // 
            // txtGap
            // 
            this.txtGap.Location = new System.Drawing.Point(150, 99);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(239, 20);
            this.txtGap.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "txt1 path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "txt2 path";
            // 
            // txtPropGrp
            // 
            this.txtPropGrp.Controls.Add(this.browseTxt1);
            this.txtPropGrp.Controls.Add(this.browseTxt2);
            this.txtPropGrp.Controls.Add(this.label2);
            this.txtPropGrp.Controls.Add(this.txt1path);
            this.txtPropGrp.Controls.Add(this.label1);
            this.txtPropGrp.Controls.Add(this.txt2path);
            this.txtPropGrp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropGrp.Location = new System.Drawing.Point(12, 63);
            this.txtPropGrp.Name = "txtPropGrp";
            this.txtPropGrp.Size = new System.Drawing.Size(436, 144);
            this.txtPropGrp.TabIndex = 11;
            this.txtPropGrp.TabStop = false;
            this.txtPropGrp.Text = "txt prop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatch);
            this.groupBox1.Controls.Add(this.txtMissmatch);
            this.groupBox1.Controls.Add(this.txtGap);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(498, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mismatch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Match";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(764, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(764, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(20, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Elapse";
            // 
            // txtCalismaSuresi
            // 
            this.txtCalismaSuresi.Location = new System.Drawing.Point(65, 269);
            this.txtCalismaSuresi.Name = "txtCalismaSuresi";
            this.txtCalismaSuresi.ReadOnly = true;
            this.txtCalismaSuresi.Size = new System.Drawing.Size(344, 20);
            this.txtCalismaSuresi.TabIndex = 11;
            // 
            // txtRichCombination
            // 
            this.txtRichCombination.Location = new System.Drawing.Point(12, 558);
            this.txtRichCombination.Name = "txtRichCombination";
            this.txtRichCombination.Size = new System.Drawing.Size(875, 139);
            this.txtRichCombination.TabIndex = 17;
            this.txtRichCombination.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(20, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(870, 203);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(909, 709);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRichCombination);
            this.Controls.Add(this.txtCalismaSuresi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPropGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.txtPropGrp.ResumeLayout(false);
            this.txtPropGrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseTxt1;
        private System.Windows.Forms.Button browseTxt2;
        private System.Windows.Forms.TextBox txt1path;
        private System.Windows.Forms.TextBox txt2path;
        private System.Windows.Forms.TextBox txtMatch;
        private System.Windows.Forms.TextBox txtMissmatch;
        private System.Windows.Forms.TextBox txtGap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox txtPropGrp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalismaSuresi;
        private System.Windows.Forms.RichTextBox txtRichCombination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

