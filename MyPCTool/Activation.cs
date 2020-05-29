using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPCTool
{
    public partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string targetDir1 = AppDomain.CurrentDomain.BaseDirectory; //或者这样写，获取程序目录
       
                Process process = new Process();   // params 为 string 类型的参数，多个参数以空格分隔，如果某个参数为空，可以传入””
                ProcessStartInfo startInfo = new ProcessStartInfo();
               process.StartInfo.FileName = "KMS.exe";
                process.StartInfo.WorkingDirectory = targetDir1;
                process.Start();
 
        }
    }
}
