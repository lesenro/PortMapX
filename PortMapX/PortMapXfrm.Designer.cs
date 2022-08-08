namespace PortMapX
{
    partial class PortMapXfrm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortMapXfrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.runState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forwardStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_start = new System.Windows.Forms.ToolStripButton();
            this.btn_stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_edit = new System.Windows.Forms.ToolStripButton();
            this.btn_clear_logs = new System.Windows.Forms.ToolStripButton();
            this.txt_logs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dg_tasks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_logs);
            this.splitContainer1.Size = new System.Drawing.Size(670, 420);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 3;
            // 
            // dg_tasks
            // 
            this.dg_tasks.AllowUserToAddRows = false;
            this.dg_tasks.AllowUserToDeleteRows = false;
            this.dg_tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.runState,
            this.monitor,
            this.protocol,
            this.timeout,
            this.forwardStr});
            this.dg_tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_tasks.Location = new System.Drawing.Point(0, 0);
            this.dg_tasks.MultiSelect = false;
            this.dg_tasks.Name = "dg_tasks";
            this.dg_tasks.ReadOnly = true;
            this.dg_tasks.RowTemplate.Height = 23;
            this.dg_tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_tasks.Size = new System.Drawing.Size(670, 212);
            this.dg_tasks.TabIndex = 0;
            this.dg_tasks.SelectionChanged += new System.EventHandler(this.dg_tasks_SelectionChanged);
            // 
            // runState
            // 
            this.runState.DataPropertyName = "runState";
            this.runState.HeaderText = "状态";
            this.runState.Name = "runState";
            this.runState.ReadOnly = true;
            // 
            // monitor
            // 
            this.monitor.DataPropertyName = "monitor";
            this.monitor.HeaderText = "监听";
            this.monitor.Name = "monitor";
            this.monitor.ReadOnly = true;
            // 
            // protocol
            // 
            this.protocol.DataPropertyName = "protocol";
            this.protocol.HeaderText = "协议";
            this.protocol.Name = "protocol";
            this.protocol.ReadOnly = true;
            // 
            // timeout
            // 
            this.timeout.DataPropertyName = "timeout";
            this.timeout.HeaderText = "超时";
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
            // 
            // forwardStr
            // 
            this.forwardStr.DataPropertyName = "forwardStr";
            this.forwardStr.HeaderText = "转发";
            this.forwardStr.Name = "forwardStr";
            this.forwardStr.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_start,
            this.btn_stop,
            this.btn_clear_logs,
            this.toolStripSeparator1,
            this.btn_add,
            this.btn_delete,
            this.btn_edit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_start
            // 
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(52, 22);
            this.btn_start.Text = "开始";
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(52, 22);
            this.btn_stop.Text = "停止";
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(52, 22);
            this.btn_add.Text = "添加";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 22);
            this.btn_delete.Text = "删除";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(52, 22);
            this.btn_edit.Text = "编辑";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_clear_logs
            // 
            this.btn_clear_logs.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear_logs.Image")));
            this.btn_clear_logs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear_logs.Name = "btn_clear_logs";
            this.btn_clear_logs.Size = new System.Drawing.Size(76, 22);
            this.btn_clear_logs.Text = "清除日志";
            this.btn_clear_logs.Click += new System.EventHandler(this.btn_clear_logs_Click);
            // 
            // txt_logs
            // 
            this.txt_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_logs.Location = new System.Drawing.Point(0, 0);
            this.txt_logs.MaxLength = 100;
            this.txt_logs.Multiline = true;
            this.txt_logs.Name = "txt_logs";
            this.txt_logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_logs.Size = new System.Drawing.Size(670, 204);
            this.txt_logs.TabIndex = 0;
            // 
            // PortMapXfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 445);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PortMapXfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "端口映射转发";
            this.Load += new System.EventHandler(this.PortMapXfrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_start;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_edit;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn runState;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn forwardStr;
        private System.Windows.Forms.ToolStripButton btn_stop;
        private System.Windows.Forms.ToolStripButton btn_clear_logs;
        private System.Windows.Forms.TextBox txt_logs;
    }
}

