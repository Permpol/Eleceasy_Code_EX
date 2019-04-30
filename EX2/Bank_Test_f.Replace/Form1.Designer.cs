namespace Bank_Test_f.Replace
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.chBox1 = new System.Windows.Forms.CheckBox();
            this.chBox2 = new System.Windows.Forms.CheckBox();
            this.chBox3 = new System.Windows.Forms.CheckBox();
            this.SubmitCh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioFemale2 = new System.Windows.Forms.TabPage();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Output1 = new System.Windows.Forms.Label();
            this.label_Output2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.radioFemale2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.SubmitCh);
            this.tabPage2.Controls.Add(this.chBox3);
            this.tabPage2.Controls.Add(this.chBox2);
            this.tabPage2.Controls.Add(this.chBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ChBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(96, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check Box Test";
            // 
            // chBox1
            // 
            this.chBox1.AutoSize = true;
            this.chBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chBox1.Location = new System.Drawing.Point(40, 80);
            this.chBox1.Name = "chBox1";
            this.chBox1.Size = new System.Drawing.Size(93, 24);
            this.chBox1.TabIndex = 1;
            this.chBox1.Text = "อ่านหนังสือ";
            this.chBox1.UseVisualStyleBackColor = true;
            this.chBox1.CheckedChanged += new System.EventHandler(this.chBox1_CheckedChanged);
            // 
            // chBox2
            // 
            this.chBox2.AutoSize = true;
            this.chBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chBox2.Location = new System.Drawing.Point(40, 112);
            this.chBox2.Name = "chBox2";
            this.chBox2.Size = new System.Drawing.Size(108, 24);
            this.chBox2.TabIndex = 2;
            this.chBox2.Text = "ออกกำลังกาย";
            this.chBox2.UseVisualStyleBackColor = true;
            this.chBox2.CheckedChanged += new System.EventHandler(this.chBox2_CheckedChanged);
            // 
            // chBox3
            // 
            this.chBox3.AutoSize = true;
            this.chBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chBox3.Location = new System.Drawing.Point(40, 144);
            this.chBox3.Name = "chBox3";
            this.chBox3.Size = new System.Drawing.Size(118, 24);
            this.chBox3.TabIndex = 3;
            this.chBox3.Text = "เขียนโปรแกรม";
            this.chBox3.UseVisualStyleBackColor = true;
            this.chBox3.CheckedChanged += new System.EventHandler(this.chBox3_CheckedChanged);
            // 
            // SubmitCh
            // 
            this.SubmitCh.Location = new System.Drawing.Point(144, 184);
            this.SubmitCh.Name = "SubmitCh";
            this.SubmitCh.Size = new System.Drawing.Size(75, 23);
            this.SubmitCh.TabIndex = 4;
            this.SubmitCh.Text = "ตรวจสอบ";
            this.SubmitCh.UseVisualStyleBackColor = true;
            this.SubmitCh.Click += new System.EventHandler(this.SubmitCh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(40, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "สิ่งที่คุณสนใจ เลือกได้มากกว่า 1 ข้อ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioFemale2
            // 
            this.radioFemale2.Controls.Add(this.radioFemale);
            this.radioFemale2.Controls.Add(this.radioMan);
            this.radioFemale2.Controls.Add(this.label3);
            this.radioFemale2.Controls.Add(this.Clear);
            this.radioFemale2.Controls.Add(this.label_Output2);
            this.radioFemale2.Controls.Add(this.label_Output1);
            this.radioFemale2.Controls.Add(this.label2);
            this.radioFemale2.Controls.Add(this.textInput1);
            this.radioFemale2.Controls.Add(this.label1);
            this.radioFemale2.Controls.Add(this.Submit);
            this.radioFemale2.Location = new System.Drawing.Point(4, 22);
            this.radioFemale2.Name = "radioFemale2";
            this.radioFemale2.Padding = new System.Windows.Forms.Padding(3);
            this.radioFemale2.Size = new System.Drawing.Size(464, 326);
            this.radioFemale2.TabIndex = 0;
            this.radioFemale2.Text = "Replace";
            this.radioFemale2.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(72, 120);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรมที่ 1";
            // 
            // textInput1
            // 
            this.textInput1.Location = new System.Drawing.Point(72, 80);
            this.textInput1.Name = "textInput1";
            this.textInput1.Size = new System.Drawing.Size(200, 20);
            this.textInput1.TabIndex = 2;
            this.textInput1.TextChanged += new System.EventHandler(this.textInput1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อ-สกุล";
            // 
            // label_Output1
            // 
            this.label_Output1.AutoSize = true;
            this.label_Output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Output1.Location = new System.Drawing.Point(24, 168);
            this.label_Output1.Name = "label_Output1";
            this.label_Output1.Size = new System.Drawing.Size(40, 24);
            this.label_Output1.TabIndex = 4;
            this.label_Output1.Text = "ชื่อ :";
            this.label_Output1.Click += new System.EventHandler(this.label_Output1_Click);
            // 
            // label_Output2
            // 
            this.label_Output2.AutoSize = true;
            this.label_Output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Output2.Location = new System.Drawing.Point(24, 208);
            this.label_Output2.Name = "label_Output2";
            this.label_Output2.Size = new System.Drawing.Size(80, 24);
            this.label_Output2.TabIndex = 5;
            this.label_Output2.Text = "นามสกุล :";
            this.label_Output2.Click += new System.EventHandler(this.label_Output2_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(168, 120);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "เพศ : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Location = new System.Drawing.Point(72, 48);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(44, 17);
            this.radioMan.TabIndex = 8;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "ชาย";
            this.radioMan.UseVisualStyleBackColor = true;
            this.radioMan.CheckedChanged += new System.EventHandler(this.radioMan_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(136, 48);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(46, 17);
            this.radioFemale.TabIndex = 9;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "หญิง";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.radioFemale2);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 352);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.radioFemale2.ResumeLayout(false);
            this.radioFemale2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitCh;
        private System.Windows.Forms.CheckBox chBox3;
        private System.Windows.Forms.CheckBox chBox2;
        private System.Windows.Forms.CheckBox chBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage radioFemale2;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label_Output2;
        private System.Windows.Forms.Label label_Output1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TabControl tabControl1;


    }
}

