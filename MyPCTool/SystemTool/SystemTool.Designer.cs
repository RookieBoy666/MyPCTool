namespace MyPCTool.SystemTool
{
    partial class SystemTool
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
            this.GPU = new System.Windows.Forms.Button();
            this.CPUZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GPU
            // 
            this.GPU.Location = new System.Drawing.Point(85, 59);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(75, 23);
            this.GPU.TabIndex = 0;
            this.GPU.Text = "GPU-Z";
            this.GPU.UseVisualStyleBackColor = true;
            this.GPU.Click += new System.EventHandler(this.button1_Click);
            // 
            // CPUZ
            // 
            this.CPUZ.Location = new System.Drawing.Point(206, 58);
            this.CPUZ.Name = "CPUZ";
            this.CPUZ.Size = new System.Drawing.Size(75, 23);
            this.CPUZ.TabIndex = 1;
            this.CPUZ.Text = "CPU-Z";
            this.CPUZ.UseVisualStyleBackColor = true;
            this.CPUZ.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SystemTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.CPUZ);
            this.Controls.Add(this.GPU);
            this.Name = "SystemTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemTool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GPU;
        private System.Windows.Forms.Button CPUZ;
    }
}