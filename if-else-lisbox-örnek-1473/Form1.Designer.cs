namespace if_else_lisbox_örnek_1473
{
    partial class txtSayi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCıft = new System.Windows.Forms.ListBox();
            this.lbTek = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSayı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇİFT  SAYILAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEK SAYILAR";
            // 
            // lbCıft
            // 
            this.lbCıft.FormattingEnabled = true;
            this.lbCıft.Location = new System.Drawing.Point(22, 148);
            this.lbCıft.Name = "lbCıft";
            this.lbCıft.Size = new System.Drawing.Size(164, 251);
            this.lbCıft.TabIndex = 2;
            // 
            // lbTek
            // 
            this.lbTek.FormattingEnabled = true;
            this.lbTek.Location = new System.Drawing.Point(205, 148);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(171, 251);
            this.lbTek.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(205, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(161, 40);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSayı
            // 
            this.txtSayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayı.Location = new System.Drawing.Point(23, 23);
            this.txtSayı.Name = "txtSayı";
            this.txtSayı.Size = new System.Drawing.Size(176, 40);
            this.txtSayı.TabIndex = 5;
            this.txtSayı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.txtSayı);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbTek);
            this.Controls.Add(this.lbCıft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txtSayi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCıft;
        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSayı;
    }
}

