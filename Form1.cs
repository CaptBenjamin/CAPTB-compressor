/*李奕可
 * Benjamin Lee
 * Capt.Benjamin@outlook.com
 * 2021-6-27*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace CAPTB压缩器重制版
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yasuoyuan = textBox1.Text;
            string yasuomubiao = textBox2.Text;
            ZipFile.CreateFromDirectory(yasuoyuan, yasuomubiao, CompressionLevel.Optimal, true);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jieyayuan = textBox3.Text;
            string jieyamubiao = textBox4.Text;
            ZipFile.ExtractToDirectory(jieyayuan, jieyamubiao);
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "选择源文件夹";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存目标文件";
            saveFileDialog.Filter = "zip文件(*.zip)|*.zip|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveFileDialog.FileName.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "选择源压缩文件";
            dialog.Filter = "zip文件(*.zip)|*.zip|所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = dialog.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "选择目标地址";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
