namespace PortMapX
{
    partial class TaskFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_forward_add = new System.Windows.Forms.Button();
            this.btn_forward_update = new System.Windows.Forms.Button();
            this.btn_forward_del = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbox_forwards = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pan_monitor = new System.Windows.Forms.Panel();
            this.num_timeout = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_protocol = new System.Windows.Forms.ComboBox();
            this.chk_mutual = new System.Windows.Forms.CheckBox();
            this.pan_edit = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.ips_forward = new PortMapX.UcIPSet();
            this.ips_monitor = new PortMapX.UcIPSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pan_monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_timeout)).BeginInit();
            this.pan_edit.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 70);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(445, 17);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 41);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 292);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "转发";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pan_edit);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(272, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 178);
            this.panel4.TabIndex = 3;
            // 
            // btn_forward_add
            // 
            this.btn_forward_add.Location = new System.Drawing.Point(6, 3);
            this.btn_forward_add.Name = "btn_forward_add";
            this.btn_forward_add.Size = new System.Drawing.Size(55, 23);
            this.btn_forward_add.TabIndex = 0;
            this.btn_forward_add.Text = "添加";
            this.btn_forward_add.UseVisualStyleBackColor = true;
            this.btn_forward_add.Click += new System.EventHandler(this.btn_forward_add_Click);
            // 
            // btn_forward_update
            // 
            this.btn_forward_update.Location = new System.Drawing.Point(173, 3);
            this.btn_forward_update.Name = "btn_forward_update";
            this.btn_forward_update.Size = new System.Drawing.Size(51, 23);
            this.btn_forward_update.TabIndex = 0;
            this.btn_forward_update.Text = "更新";
            this.btn_forward_update.UseVisualStyleBackColor = true;
            this.btn_forward_update.Click += new System.EventHandler(this.btn_forward_update_Click);
            // 
            // btn_forward_del
            // 
            this.btn_forward_del.Location = new System.Drawing.Point(67, 3);
            this.btn_forward_del.Name = "btn_forward_del";
            this.btn_forward_del.Size = new System.Drawing.Size(46, 23);
            this.btn_forward_del.TabIndex = 0;
            this.btn_forward_del.Text = "删除";
            this.btn_forward_del.UseVisualStyleBackColor = true;
            this.btn_forward_del.Click += new System.EventHandler(this.btn_forward_del_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbox_forwards);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 178);
            this.panel3.TabIndex = 2;
            // 
            // lbox_forwards
            // 
            this.lbox_forwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_forwards.FormattingEnabled = true;
            this.lbox_forwards.ItemHeight = 12;
            this.lbox_forwards.Location = new System.Drawing.Point(0, 0);
            this.lbox_forwards.Name = "lbox_forwards";
            this.lbox_forwards.Size = new System.Drawing.Size(269, 178);
            this.lbox_forwards.TabIndex = 0;
            this.lbox_forwards.SelectedIndexChanged += new System.EventHandler(this.lbox_forwards_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pan_monitor);
            this.groupBox1.Controls.Add(this.ips_monitor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监听";
            // 
            // pan_monitor
            // 
            this.pan_monitor.Controls.Add(this.num_timeout);
            this.pan_monitor.Controls.Add(this.label1);
            this.pan_monitor.Controls.Add(this.label2);
            this.pan_monitor.Controls.Add(this.cbx_protocol);
            this.pan_monitor.Location = new System.Drawing.Point(22, 20);
            this.pan_monitor.Name = "pan_monitor";
            this.pan_monitor.Size = new System.Drawing.Size(222, 66);
            this.pan_monitor.TabIndex = 5;
            // 
            // num_timeout
            // 
            this.num_timeout.Location = new System.Drawing.Point(68, 33);
            this.num_timeout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_timeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_timeout.Name = "num_timeout";
            this.num_timeout.Size = new System.Drawing.Size(120, 21);
            this.num_timeout.TabIndex = 4;
            this.num_timeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "协议";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "超时";
            // 
            // cbx_protocol
            // 
            this.cbx_protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_protocol.FormattingEnabled = true;
            this.cbx_protocol.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.cbx_protocol.Location = new System.Drawing.Point(68, 7);
            this.cbx_protocol.Name = "cbx_protocol";
            this.cbx_protocol.Size = new System.Drawing.Size(121, 20);
            this.cbx_protocol.TabIndex = 2;
            // 
            // chk_mutual
            // 
            this.chk_mutual.AutoSize = true;
            this.chk_mutual.Location = new System.Drawing.Point(22, 81);
            this.chk_mutual.Name = "chk_mutual";
            this.chk_mutual.Size = new System.Drawing.Size(72, 16);
            this.chk_mutual.TabIndex = 2;
            this.chk_mutual.Text = "允许交互";
            this.chk_mutual.UseVisualStyleBackColor = true;
            // 
            // pan_edit
            // 
            this.pan_edit.Controls.Add(this.ips_forward);
            this.pan_edit.Controls.Add(this.chk_mutual);
            this.pan_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_edit.Location = new System.Drawing.Point(0, 0);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(257, 147);
            this.pan_edit.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_edit);
            this.panel6.Controls.Add(this.btn_forward_add);
            this.panel6.Controls.Add(this.btn_forward_del);
            this.panel6.Controls.Add(this.btn_forward_update);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 147);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 31);
            this.panel6.TabIndex = 4;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(119, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(48, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // ips_forward
            // 
            this.ips_forward.Location = new System.Drawing.Point(6, 10);
            this.ips_forward.Name = "ips_forward";
            this.ips_forward.Size = new System.Drawing.Size(235, 65);
            this.ips_forward.TabIndex = 1;
            // 
            // ips_monitor
            // 
            this.ips_monitor.Location = new System.Drawing.Point(250, 13);
            this.ips_monitor.Name = "ips_monitor";
            this.ips_monitor.Size = new System.Drawing.Size(236, 73);
            this.ips_monitor.TabIndex = 0;
            // 
            // TaskFrm
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaskFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务设置";
            this.Load += new System.EventHandler(this.TaskFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pan_monitor.ResumeLayout(false);
            this.pan_monitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_timeout)).EndInit();
            this.pan_edit.ResumeLayout(false);
            this.pan_edit.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pan_monitor;
        private System.Windows.Forms.NumericUpDown num_timeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_protocol;
        private UcIPSet ips_monitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_forward_add;
        private System.Windows.Forms.Button btn_forward_del;
        private UcIPSet ips_forward;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbox_forwards;
        private System.Windows.Forms.Button btn_forward_update;
        private System.Windows.Forms.CheckBox chk_mutual;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel pan_edit;
    }
}