using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Threading;
namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
        }

        #region GroupFile
        // Btn

        private void BtnChFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK && op.FileName != string.Empty)
            {
                refreshFileSource(op.FileName);
            }
        }

        private void refreshFileSource(string filePath)
        {
            if (File.Exists(filePath))
            {
                FileInfo f1 = new FileInfo(filePath);
                fileNameTB.Text = filePath;
                fileSizeLB.Text = f1.Length.ToString("0,000 Bytes");
                labelisEqual1.Text = "";
                checksumTB.Text = "";
            }
        }
        private void BtnCompare_Click(object sender, EventArgs e)
        {
            new Thread(hashStream).Start();

        }

        // RadioChanged
        private void radioBtnMD5_CheckedChanged(object sender, EventArgs e)
        {
            if (!fileNameTB.Text.Equals(string.Empty))
            {
                hashStream();
                Compare();
            }
        }
        private void radioBtnSHA1_CheckedChanged(object sender, EventArgs e)
        {
            if (!fileNameTB.Text.Equals(string.Empty))
            {
                hashStream();
                Compare();
            }
        }

        // TextBoxChanged
        private void compareTB_TextChanged(object sender, EventArgs e)
        {
            Compare();
        }

        private void hashStream()
        {
            using (FileStream stream = new FileStream(fileNameTB.Text, FileMode.Open))
            {
                this.Invoke(new Action(() => labelOk.Text = "Wait.."));

                string hash = "";
                if (radioBtnMD5.Checked)
                    hash = CalculateHashMD5(stream);
                else if (radioBtnSHA1.Checked)
                    hash = CalculateHashSHA1(stream);

                this.Invoke(new Action(() => checksumTB.Text = hash));
                this.Invoke(new Action(() => labelOk.Text = "OK"));
                Compare();
            }
        }

        #endregion

        // ===============================================================================
        #region GroupStr
        // Btn
        private void BtnCalculateStr_Click(object sender, EventArgs e)
        {
            hashStr();
        }

        // RadioChanged
        private void radioBtnMD5_2_CheckedChanged(object sender, EventArgs e)
        {
            hashStr();
        }
        private void radioBtnSHA1_2_CheckedChanged(object sender, EventArgs e)
        {
            hashStr();
        }

        // TextBoxChanged
        private void InputBox1_TextChanged(object sender, EventArgs e)
        {
            string hash = "";
            if (radioBtnMD5_2.Checked)
                hash = CalculateHashMD5(InputBox1.Text);
            else if (radioBtnSHA1_2.Checked)
                hash = CalculateHashSHA1(InputBox1.Text);

            OutputBoxStr.Text = hash;
        }

        private void hashStr()
        {
            if (InputBox1.Text != "")
            {
                string hash = "";
                if (radioBtnMD5_2.Checked)
                    hash = CalculateHashMD5(InputBox1.Text);
                else if (radioBtnSHA1_2.Checked)
                    hash = CalculateHashSHA1(InputBox1.Text);

                OutputBoxStr.Text = hash;
            }
        }
        #endregion

        // ===============================================================================
        // Hash
        public string CalculateHashMD5(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 hashMethod = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = hashMethod.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            return BytesToString(hash);
        }
        public string CalculateHashMD5(Stream input)
        {
            byte[] buffer;
            int bytesRead;
            long size = input.Length;
            long totalBytesRead = 0;
            // step 1, calculate MD5 hash from input
            using (MD5 md5 = MD5.Create())
            {
                do
                {
                    buffer = new byte[4096];
                    bytesRead = input.Read(buffer, 0, buffer.Length);
                    totalBytesRead += bytesRead;
                    md5.TransformBlock(buffer, 0, bytesRead, null, 0);

                    this.Invoke(
                        new Action(() =>
                        {
                            progressBar1.Value = Convert.ToInt32((double)totalBytesRead / size * 100);
                        }));


                } while (bytesRead != 0);

                md5.TransformFinalBlock(buffer, 0, 0);
                return BytesToString(md5.Hash);
            }

        }
        public string CalculateHashSHA1(string input)
        {
            // step 1, calculate MD5 hash from input
            SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = sha1.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            return BytesToString(hash);
        }
        public string CalculateHashSHA1(Stream input)
        {
            // step 1, calculate MD5 hash from input
            SHA1 sha1 = SHA1.Create();
            byte[] hash = sha1.ComputeHash(input);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        // Other
        private void Compare()
        {
            if (String.Compare(checksumTB.Text, compareTB.Text, true) == 0)
                this.Invoke(new Action(() => labelisEqual1.Text = "V"));
            else
                this.Invoke(new Action(() => labelisEqual1.Text = "X"));
        }
        private string BytesToString(Byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void fileNameTB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }



        private void fileNameTB_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileInfo = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string filepath = string.Join("", fileInfo, 0, fileInfo.Length);

            refreshFileSource(filepath);
        }




    }
}
