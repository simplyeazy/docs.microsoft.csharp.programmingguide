using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checksumwebform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = ((OpenFileDialog) sender).FileName;
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var stream = File.OpenRead(path))
                {
                    var md5Stream = md5.ComputeHash(stream);
                    label1.Text = BitConverter.ToString(md5Stream);
                    textBox1.Text = BitConverter.ToString(md5Stream);
                }
            }
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                using (var stream = File.OpenRead(path))
                {
                    var sha1stream = sha1.ComputeHash(stream);
                    label2.Text = BitConverter.ToString(sha1stream);
                    textBox2.Text = BitConverter.ToString(sha1stream);
                }
            }

        }
    }
}
