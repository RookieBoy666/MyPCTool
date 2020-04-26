using MyPCTool.cn.com.webxml.www;
using MyTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MyPCTool
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WeatherWebService w = new WeatherWebService();
            string[] s = new string[23];//声明string数组存放返回结果  
            string city = this.textBox1.Text.Trim();//获得文本框录入的查询城市  
            s = w.getWeatherbyCityName(city);
            if (textBox1.Text == "")
            {
                //MessageBox.Show("输入错误，请重新输入", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("城市输入错误，请重新输入");
            }
            else
            {
                weatherDetail.Text = s[1] + "\n" + s[4] + s[10]+s[11];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void weatherDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new MainForm().ShowDialog(); });
            th.Start();
            this.Close();
        }
    }
}
