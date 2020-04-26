using MyTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MyPCTool
{
    public partial class ShutDownForm : Form
    {
        public ShutDownForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = this.textBox1.Text.Trim().ToString();//只能输入正整数
            bool isNumber = System.Text.RegularExpressions.Regex.IsMatch(str, @"^[1-9]\d*$"); //正则表达式  匹配正整数    
            if (isNumber)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("是否关机？", "关机提示", messButton);
                if (dr == DialogResult.OK)
                {

                    int i = (int.Parse(this.textBox1.Text.Trim().ToString()));
                    // System.Diagnostics.Process.Start("shutdown", "-s -t "+i);//功能可以实现但是有闪屏现象   体验不佳
                    Process p = new Process();//实例化一个独立进程
                    p.StartInfo.FileName = "cmd.exe";//进程打开的文件为Cmd
                    p.StartInfo.UseShellExecute = false;//是否启动系统外壳选否
                    p.StartInfo.RedirectStandardInput = true;//这是是否从StandardInput输入
                    p.StartInfo.CreateNoWindow = true;//这里是启动程序是否显示窗体
                    p.Start();//启动
                    p.StandardInput.WriteLine("shutdown -s -t " + i * 60);//运行关机命令shutdown (-s)是关机 (-t)是延迟的时间 这里用秒计算 10就是10秒后关机
                    p.StandardInput.WriteLine("exit");//退出cmd 
                    this.textBox1.Text = string.Empty;//清空文本框的值
                    MessageBox.Show(i.ToString() + "分后关机！");
                }

            }
            else
            {
                MessageBox.Show("输入非法！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new MainForm().ShowDialog(); });
            th.Start();
            this.Close();
        }
    }
}
