using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
namespace MyPCTool
{
    public partial class QRCode : Form
    {
        public QRCode()
        {
            InitializeComponent();
            this.num_Size.Text = "4";
            this.num_version.Text = "7";
        }

        /// <summary>
        /// 生成二维码事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateQRCode_Click(object sender, EventArgs e)
        {
            //获取生成二维码的参数（规模、版本、链接地址）
            int size = Convert.ToInt32(this.num_Size.Text);
            int version = Convert.ToInt32(this.num_version.Text);
            string linkaddress = this.txb_LinkAddress.Text.ToString();
            //调用生成二维码图片的事件，并把图片显示在图片框中
            Image img = QrCodeBitmap(linkaddress, size, version);
            this.pic_MyImg.Image = img;
        }

        /// <summary>
        /// 保存二维码事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveQRCode_Click(object sender, EventArgs e)
        {
            if (this.pic_MyImg.Image == null)
            {
                MessageBox.Show("没有可用的二维码图片！");
            }
            else
            {
                SaveFileDialog saveqrimg = new SaveFileDialog();
                saveqrimg.Title = "二维码图片保存";
                saveqrimg.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif";
                if (saveqrimg.ShowDialog() == DialogResult.OK)
                {
                    this.pic_MyImg.Image.Save(saveqrimg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        /// <summary>
        /// 生成二维码位图
        /// </summary>
        /// <param name="link">用于生成二维码的链接</param>4
        /// <param name="size">二维码规模大小</param>
        /// <param name="version">二维码版本</param>
        /// <returns>二维码图片对象</returns>
        private Image QrCodeBitmap(string link, int size, int version)
        {
            QRCodeEncoder qrcodeencoder = new QRCodeEncoder();//生成设置编码实例
            qrcodeencoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//字节编码
            qrcodeencoder.QRCodeScale = size;//二维码规模大小
            qrcodeencoder.QRCodeVersion = version;//二维码版本
            qrcodeencoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//设置错误校验（错误更正）的级别：中等M
            Image img = qrcodeencoder.Encode(link);//生成二维码image图片
            return img;
        }

        private void btnSaveQRCode_Click_1(object sender, EventArgs e)
        {

            if (this.pic_MyImg.Image == null)
            {
                MessageBox.Show("没有可用的二维码图片！");
            }
            else
            {
                Thread t = new Thread((ThreadStart)(() =>
                {
                    SaveFileDialog saveqrimg = new SaveFileDialog();
                saveqrimg.Title = "二维码图片保存";
                saveqrimg.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif";
                if (saveqrimg.ShowDialog() == DialogResult.OK)
                {
                    this.pic_MyImg.Image.Save(saveqrimg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                    {
                        MessageBox.Show("保存失败！");
                    }
                }
                ));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
        }
    }
}
