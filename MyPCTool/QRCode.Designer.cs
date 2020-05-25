namespace MyPCTool
{
    partial class QRCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Size = new System.Windows.Forms.NumericUpDown();
            this.num_version = new System.Windows.Forms.NumericUpDown();
            this.内容 = new System.Windows.Forms.Label();
            this.txb_LinkAddress = new System.Windows.Forms.TextBox();
            this.btnCreateQRCode = new System.Windows.Forms.Button();
            this.btnSaveQRCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_MyImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_version)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MyImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "二维码规模";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "二维码版本";
            // 
            // num_Size
            // 
            this.num_Size.Location = new System.Drawing.Point(105, 25);
            this.num_Size.Name = "num_Size";
            this.num_Size.Size = new System.Drawing.Size(120, 21);
            this.num_Size.TabIndex = 2;
            // 
            // num_version
            // 
            this.num_version.Location = new System.Drawing.Point(441, 33);
            this.num_version.Name = "num_version";
            this.num_version.Size = new System.Drawing.Size(120, 21);
            this.num_version.TabIndex = 3;
            // 
            // 内容
            // 
            this.内容.AutoSize = true;
            this.内容.Location = new System.Drawing.Point(35, 78);
            this.内容.Name = "内容";
            this.内容.Size = new System.Drawing.Size(29, 12);
            this.内容.TabIndex = 4;
            this.内容.Text = "内容";
            // 
            // txb_LinkAddress
            // 
            this.txb_LinkAddress.Location = new System.Drawing.Point(105, 75);
            this.txb_LinkAddress.Name = "txb_LinkAddress";
            this.txb_LinkAddress.Size = new System.Drawing.Size(456, 21);
            this.txb_LinkAddress.TabIndex = 5;
            // 
            // btnCreateQRCode
            // 
            this.btnCreateQRCode.Location = new System.Drawing.Point(193, 130);
            this.btnCreateQRCode.Name = "btnCreateQRCode";
            this.btnCreateQRCode.Size = new System.Drawing.Size(75, 23);
            this.btnCreateQRCode.TabIndex = 6;
            this.btnCreateQRCode.Text = "生成二维码";
            this.btnCreateQRCode.UseVisualStyleBackColor = true;
            this.btnCreateQRCode.Click += new System.EventHandler(this.btnCreateQRCode_Click);
            // 
            // btnSaveQRCode
            // 
            this.btnSaveQRCode.Location = new System.Drawing.Point(333, 130);
            this.btnSaveQRCode.Name = "btnSaveQRCode";
            this.btnSaveQRCode.Size = new System.Drawing.Size(75, 23);
            this.btnSaveQRCode.TabIndex = 7;
            this.btnSaveQRCode.Text = "保存";
            this.btnSaveQRCode.UseVisualStyleBackColor = true;
            this.btnSaveQRCode.Click += new System.EventHandler(this.btnSaveQRCode_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_MyImg);
            this.panel1.Location = new System.Drawing.Point(105, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 335);
            this.panel1.TabIndex = 8;
            // 
            // pic_MyImg
            // 
            this.pic_MyImg.Location = new System.Drawing.Point(88, 40);
            this.pic_MyImg.Name = "pic_MyImg";
            this.pic_MyImg.Size = new System.Drawing.Size(252, 237);
            this.pic_MyImg.TabIndex = 0;
            this.pic_MyImg.TabStop = false;
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveQRCode);
            this.Controls.Add(this.btnCreateQRCode);
            this.Controls.Add(this.txb_LinkAddress);
            this.Controls.Add(this.内容);
            this.Controls.Add(this.num_version);
            this.Controls.Add(this.num_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_version)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_MyImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Size;
        private System.Windows.Forms.NumericUpDown num_version;
        private System.Windows.Forms.Label 内容;
        private System.Windows.Forms.TextBox txb_LinkAddress;
        private System.Windows.Forms.Button btnCreateQRCode;
        private System.Windows.Forms.Button btnSaveQRCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_MyImg;
    }
}