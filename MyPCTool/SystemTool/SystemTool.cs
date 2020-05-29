using MyPCTool.ClassHelper;
using System;
using System.Windows.Forms;

namespace MyPCTool.SystemTool
{
    public partial class SystemTool : Form
    {
        public SystemTool()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string targetDir1 = AppDomain.CurrentDomain.BaseDirectory; //或者这样写，获取程序目录
                StartExeFile.runExe(targetDir1, "GPU-Z.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到文件！");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string targetDir1 = AppDomain.CurrentDomain.BaseDirectory; //或者这样写，获取程序目录
                StartExeFile.runExe(targetDir1, "CPU-Z.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到文件！");
                Log.RegisterLog(ex.Message , DateTime.Now.ToString());
            }
        }
    }
}
