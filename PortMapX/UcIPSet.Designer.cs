namespace PortMapX
{
    partial class UcIPSet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.num_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(62, 13);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(150, 21);
            this.txt_ip.TabIndex = 3;
            // 
            // num_port
            // 
            this.num_port.Location = new System.Drawing.Point(62, 40);
            this.num_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_port.Name = "num_port";
            this.num_port.Size = new System.Drawing.Size(80, 21);
            this.num_port.TabIndex = 4;
            // 
            // UcIPSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.num_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UcIPSet";
            this.Size = new System.Drawing.Size(257, 99);
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.NumericUpDown num_port;
    }
}
