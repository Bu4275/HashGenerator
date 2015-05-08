namespace Hash
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.labelOk = new System.Windows.Forms.Label();
            this.radioBtnSHA1 = new System.Windows.Forms.RadioButton();
            this.radioBtnMD5 = new System.Windows.Forms.RadioButton();
            this.labelisEqual1 = new System.Windows.Forms.Label();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.compareTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSizeLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnChFile = new System.Windows.Forms.Button();
            this.checksumTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnSHA1_2 = new System.Windows.Forms.RadioButton();
            this.radioBtnMD5_2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputBox1 = new System.Windows.Forms.RichTextBox();
            this.OutputBoxStr = new System.Windows.Forms.TextBox();
            this.BtnCalculateStr = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileNameTB);
            this.groupBox1.Controls.Add(this.labelOk);
            this.groupBox1.Controls.Add(this.radioBtnSHA1);
            this.groupBox1.Controls.Add(this.radioBtnMD5);
            this.groupBox1.Controls.Add(this.labelisEqual1);
            this.groupBox1.Controls.Add(this.BtnCompare);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.compareTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fileSizeLB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnChFile);
            this.groupBox1.Controls.Add(this.checksumTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 193);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MD5 & SHA1 Hash Generator For File";
            // 
            // fileNameTB
            // 
            this.fileNameTB.AllowDrop = true;
            this.fileNameTB.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fileNameTB.Location = new System.Drawing.Point(124, 22);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.ReadOnly = true;
            this.fileNameTB.Size = new System.Drawing.Size(386, 23);
            this.fileNameTB.TabIndex = 42;
            this.fileNameTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileNameTB_DragDrop);
            this.fileNameTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileNameTB_DragEnter);
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOk.Location = new System.Drawing.Point(510, 96);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(0, 16);
            this.labelOk.TabIndex = 41;
            // 
            // radioBtnSHA1
            // 
            this.radioBtnSHA1.AutoSize = true;
            this.radioBtnSHA1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnSHA1.Location = new System.Drawing.Point(177, 71);
            this.radioBtnSHA1.Name = "radioBtnSHA1";
            this.radioBtnSHA1.Size = new System.Drawing.Size(57, 20);
            this.radioBtnSHA1.TabIndex = 40;
            this.radioBtnSHA1.Text = "SHA1";
            this.radioBtnSHA1.UseVisualStyleBackColor = true;
            this.radioBtnSHA1.CheckedChanged += new System.EventHandler(this.radioBtnSHA1_CheckedChanged);
            // 
            // radioBtnMD5
            // 
            this.radioBtnMD5.AutoSize = true;
            this.radioBtnMD5.Checked = true;
            this.radioBtnMD5.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnMD5.Location = new System.Drawing.Point(124, 71);
            this.radioBtnMD5.Name = "radioBtnMD5";
            this.radioBtnMD5.Size = new System.Drawing.Size(54, 20);
            this.radioBtnMD5.TabIndex = 39;
            this.radioBtnMD5.TabStop = true;
            this.radioBtnMD5.Text = "MD5";
            this.radioBtnMD5.UseVisualStyleBackColor = true;
            this.radioBtnMD5.CheckedChanged += new System.EventHandler(this.radioBtnMD5_CheckedChanged);
            // 
            // labelisEqual1
            // 
            this.labelisEqual1.AutoSize = true;
            this.labelisEqual1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelisEqual1.Location = new System.Drawing.Point(517, 124);
            this.labelisEqual1.Name = "labelisEqual1";
            this.labelisEqual1.Size = new System.Drawing.Size(0, 16);
            this.labelisEqual1.TabIndex = 38;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCompare.Location = new System.Drawing.Point(436, 149);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(75, 27);
            this.BtnCompare.TabIndex = 37;
            this.BtnCompare.Text = "Calculate";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Compare with:";
            // 
            // compareTB
            // 
            this.compareTB.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.compareTB.Location = new System.Drawing.Point(124, 121);
            this.compareTB.Name = "compareTB";
            this.compareTB.Size = new System.Drawing.Size(387, 23);
            this.compareTB.TabIndex = 35;
            this.compareTB.TextChanged += new System.EventHandler(this.compareTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Checksum type:";
            // 
            // fileSizeLB
            // 
            this.fileSizeLB.AutoSize = true;
            this.fileSizeLB.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fileSizeLB.Location = new System.Drawing.Point(121, 46);
            this.fileSizeLB.Name = "fileSizeLB";
            this.fileSizeLB.Size = new System.Drawing.Size(0, 16);
            this.fileSizeLB.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "FileSize:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filename:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "File checksum:";
            // 
            // BtnChFile
            // 
            this.BtnChFile.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnChFile.Location = new System.Drawing.Point(343, 149);
            this.BtnChFile.Name = "BtnChFile";
            this.BtnChFile.Size = new System.Drawing.Size(75, 27);
            this.BtnChFile.TabIndex = 28;
            this.BtnChFile.Text = "Select File";
            this.BtnChFile.UseVisualStyleBackColor = true;
            this.BtnChFile.Click += new System.EventHandler(this.BtnChFile_Click);
            // 
            // checksumTB
            // 
            this.checksumTB.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checksumTB.Location = new System.Drawing.Point(124, 93);
            this.checksumTB.Name = "checksumTB";
            this.checksumTB.Size = new System.Drawing.Size(387, 23);
            this.checksumTB.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnSHA1_2);
            this.groupBox2.Controls.Add(this.radioBtnMD5_2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.InputBox1);
            this.groupBox2.Controls.Add(this.OutputBoxStr);
            this.groupBox2.Controls.Add(this.BtnCalculateStr);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 269);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MD5 & SHA1 Hash Generator For Text";
            // 
            // radioBtnSHA1_2
            // 
            this.radioBtnSHA1_2.AutoSize = true;
            this.radioBtnSHA1_2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnSHA1_2.Location = new System.Drawing.Point(177, 178);
            this.radioBtnSHA1_2.Name = "radioBtnSHA1_2";
            this.radioBtnSHA1_2.Size = new System.Drawing.Size(57, 20);
            this.radioBtnSHA1_2.TabIndex = 43;
            this.radioBtnSHA1_2.Text = "SHA1";
            this.radioBtnSHA1_2.UseVisualStyleBackColor = true;
            this.radioBtnSHA1_2.CheckedChanged += new System.EventHandler(this.radioBtnSHA1_2_CheckedChanged);
            // 
            // radioBtnMD5_2
            // 
            this.radioBtnMD5_2.AutoSize = true;
            this.radioBtnMD5_2.Checked = true;
            this.radioBtnMD5_2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnMD5_2.Location = new System.Drawing.Point(124, 178);
            this.radioBtnMD5_2.Name = "radioBtnMD5_2";
            this.radioBtnMD5_2.Size = new System.Drawing.Size(54, 20);
            this.radioBtnMD5_2.TabIndex = 42;
            this.radioBtnMD5_2.TabStop = true;
            this.radioBtnMD5_2.Text = "MD5";
            this.radioBtnMD5_2.UseVisualStyleBackColor = true;
            this.radioBtnMD5_2.CheckedChanged += new System.EventHandler(this.radioBtnMD5_2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(15, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Checksum type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(14, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "String hash:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Generate the hash of the string you input";
            // 
            // InputBox1
            // 
            this.InputBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputBox1.Location = new System.Drawing.Point(8, 44);
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(528, 117);
            this.InputBox1.TabIndex = 28;
            this.InputBox1.Text = "";
            this.InputBox1.TextChanged += new System.EventHandler(this.InputBox1_TextChanged);
            // 
            // OutputBoxStr
            // 
            this.OutputBoxStr.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputBoxStr.Location = new System.Drawing.Point(124, 200);
            this.OutputBoxStr.Name = "OutputBoxStr";
            this.OutputBoxStr.Size = new System.Drawing.Size(412, 25);
            this.OutputBoxStr.TabIndex = 27;
            // 
            // BtnCalculateStr
            // 
            this.BtnCalculateStr.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCalculateStr.Location = new System.Drawing.Point(452, 236);
            this.BtnCalculateStr.Name = "BtnCalculateStr";
            this.BtnCalculateStr.Size = new System.Drawing.Size(84, 27);
            this.BtnCalculateStr.TabIndex = 26;
            this.BtnCalculateStr.Text = "Calculate";
            this.BtnCalculateStr.UseVisualStyleBackColor = true;
            this.BtnCalculateStr.Click += new System.EventHandler(this.BtnCalculateStr_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 486);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 514);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Hash Generator By Bubu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnSHA1;
        private System.Windows.Forms.RadioButton radioBtnMD5;
        private System.Windows.Forms.Label labelisEqual1;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox compareTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fileSizeLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnChFile;
        private System.Windows.Forms.TextBox checksumTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox InputBox1;
        private System.Windows.Forms.TextBox OutputBoxStr;
        private System.Windows.Forms.Button BtnCalculateStr;
        private System.Windows.Forms.RadioButton radioBtnSHA1_2;
        private System.Windows.Forms.RadioButton radioBtnMD5_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelOk;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.ProgressBar progressBar1;



    }
}

