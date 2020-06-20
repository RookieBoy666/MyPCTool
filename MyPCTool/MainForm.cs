using MyPCTool;
using MyPCTool.ClassHelper;
using MyPCTool.SystemTool;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace MyTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getBatFile("系统安装日期.bat");
        }
        /// <summary>
        /// filename//bat文件名称
        /// </summary>
        /// <param name="filename"></param>
        private void getBatFile(string filename)
        {
            Process proc = null;
            try
            {
                // string targetDir = string.Format(@"D:\BizMap\");//这是bat存放的目录
                string targetDir1 = AppDomain.CurrentDomain.BaseDirectory; //或者这样写，获取程序目录
                //D:\\Project\\MyPCTool\\MyPCTool\\bin\\Debug\\

                targetDir1 = targetDir1.Replace("bin\\Debug\\", "Dos\\");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir1;
                proc.StartInfo.FileName = filename;//bat文件名称
                proc.StartInfo.Arguments = string.Format("10");//this is argument                                    //proc.StartInfo.CreateNoWindow = true;
                //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//这里设置DOS窗口不显示，经实践可行
                proc.Start();
                proc.WaitForExit();
                // MessageBox.Show("成功！");
                // Log.RegisterLog(filename + "  成功", DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
                MessageBox.Show("失败！原因:" + ex.Message + "");
                //  Log.RegisterLog(ex.Message, DateTime.Now.ToString());
            }
        }
        //dosCommand Dos命令语句    
        public string Execute(string dosCommand)
        {
            return Execute(dosCommand, 10);
        }
        /// <summary>    
        /// 执行DOS命令，返回DOS命令的输出    
        /// </summary>    
        /// <param name="dosCommand">dos命令</param>    
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），    
        /// 如果设定为0，则无限等待</param>    
        /// <returns>返回DOS命令的输出</returns>    
        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串    
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象    
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令    
                startInfo.Arguments = "/C/windows/system32/" + command;//“/C”表示执行完命令后马上退出    
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动    
                startInfo.RedirectStandardInput = false;//不重定向输入    
                startInfo.RedirectStandardOutput = true; //重定向输出    
                startInfo.CreateNoWindow = true;//不创建窗口    
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程    
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束    
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒    
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出    
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getBatFile("网络重置.bat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnimate.AnimateWindow(this.Handle, 2000, FormAnimate.AW_SLIDE | FormAnimate.AW_HIDE | FormAnimate.AW_BLEND);
            this.Close();
            this.Dispose();
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    string str = this.textBox1.Text.Trim().ToString();//只能输入正整数
        //    bool isNumber = System.Text.RegularExpressions.Regex.IsMatch(str, @"^[1-9]\d*$"); //正则表达式  匹配正整数    
        //    if (isNumber)
        //    {
        //        MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
        //        DialogResult dr = MessageBox.Show("是否关机？", "关机提示", messButton);
        //        if (dr == DialogResult.OK)
        //        {

        //            int i = (int.Parse(this.textBox1.Text.Trim().ToString()));
        //            // System.Diagnostics.Process.Start("shutdown", "-s -t "+i);//功能可以实现但是有闪屏现象   体验不佳
        //            Process p = new Process();//实例化一个独立进程
        //            p.StartInfo.FileName = "cmd.exe";//进程打开的文件为Cmd
        //            p.StartInfo.UseShellExecute = false;//是否启动系统外壳选否
        //            p.StartInfo.RedirectStandardInput = true;//这是是否从StandardInput输入
        //            p.StartInfo.CreateNoWindow = true;//这里是启动程序是否显示窗体
        //            p.Start();//启动
        //            p.StandardInput.WriteLine("shutdown -s -t " + i * 60);//运行关机命令shutdown (-s)是关机 (-t)是延迟的时间 这里用秒计算 10就是10秒后关机
        //            p.StandardInput.WriteLine("exit");//退出cmd 
        //            this.textBox1.Text = string.Empty;//清空文本框的值
        //            MessageBox.Show(i.ToString() + "分后关机！");
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("输入非法！");
        //    }
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            getBatFile("清除缓存.bat");
        }

        //private void button6_Click(object sender, EventArgs e)
        //{

        //    string url = "http://www.tianqihoubao.com/lishi/beijing/month/201101.html";
        //    string html = Weather.GetHtml(url);
        //    var links = Weather.ParseLink(html);
        //    foreach (var link in links)
        //    {
        //        url = "http://www.tianqihoubao.com" + link;
        //        html = Weather.GetHtml(url);
        //        Weather.ParseDailyWeather(html);
        //    }

        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //     WeatherWebService w = new  WeatherWebService();
        //    string[] s = new string[23];//声明string数组存放返回结果  
        //    string city = this.textBox1.Text.Trim();//获得文本框录入的查询城市  
        //    s = w.getWeatherbyCityName(city);
        //    if (textBox1.Text == "")
        //    {
        //          //MessageBox.Show("输入错误，请重新输入", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    else
        //    {
        //        textBox2.Text = s[1] + " " + s[4] + s[10];
        //    }   



        //}

        private void button7_Click_1(object sender, EventArgs e)
        {

            Thread th = new Thread(delegate () { new WeatherForm().ShowDialog(); });
            th.Start();
            //this.Close();
            ////this.Close();
            //this.Dispose();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormAnimate.AnimateWindow(this.Handle, 1000, FormAnimate.AW_BLEND);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new ShutDownForm().ShowDialog(); });
            th.Start();
            //this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new QRCode().ShowDialog(); });
            th.Start();
        }

        private void File_Click(object sender, EventArgs e)
        {
            // Thread th = new Thread(delegate () { new File().ShowDialog(); });
            File file = new File();
            file.Show();
        }

        private void activation_Click(object sender, EventArgs e)
        {
            Activation activation = new Activation();
            activation.Show();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new AboutForm().ShowDialog(); });
            th.Start();

            //this.Close();
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUpdate update = new AboutUpdate();
            update.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SystemTool tool = new SystemTool();
            tool.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnimate.AnimateWindow(this.Handle, 1000, FormAnimate.AW_SLIDE | FormAnimate.AW_HIDE | FormAnimate.AW_BLEND);
        }
    }
}
