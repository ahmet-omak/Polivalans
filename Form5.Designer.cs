namespace Polivalans
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(322, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Mail Gönder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-Mail:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 27);
            this.textBox2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(255, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 25);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Şifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hotmail",
            "Gmail",
            "Yahoo"});
            this.comboBox1.Location = new System.Drawing.Point(122, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 29);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Mail Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bütün Kutucukları Doldurduğunuzdan Emin Olunuz!";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(18, 347);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(450, 60);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(526, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mesaj Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(86, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 114);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mesaj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Konu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kime:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(312, 27);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 27);
            this.textBox3.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Crimson;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(526, 347);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(450, 60);
            this.sendButton.TabIndex = 1;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "Ekle  ve/veya Gönder";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(801, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Made By Ahmet Omak";
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme - Kalmaksan Kalıp";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}