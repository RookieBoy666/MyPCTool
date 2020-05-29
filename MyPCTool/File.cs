using System;
using System.Windows.Forms;

namespace MyPCTool
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //弹出一个选择目录的对话框
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtPath.Text = path.SelectedPath;

            //弹出一个选择文件的对话框
            //OpenFileDialog file = new OpenFileDialog();
            //file.ShowDialog();
            //this.txtPath.Text = file.SafeFileName;

        }


    }
}
