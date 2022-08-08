using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortMapX
{
    public partial class TaskFrm : Form
    {
        public event Action<TaskConfig> TaskConfigSave;

        private BindingList<AddrInfo> forwardlist = new BindingList<AddrInfo>();
        private int editId = 0;
        private int taskId = 0;
        private int backId = 0;
        public TaskFrm()
        {
            InitializeComponent();
        }
        public void FillForm(TaskConfig tcfg)
        {
            cbx_protocol.SelectedItem = tcfg.protocol;
            num_timeout.Value = tcfg.timeout;
            ips_monitor.FillValue(tcfg.monitor);
            foreach (var f in tcfg.forwards)
            {
                forwardlist.Add(f);
            }
            ips_forward.FillValue(tcfg.forwards.FirstOrDefault() ?? new AddrInfo());
            taskId = tcfg.id;
            backId = tcfg.GetBackId();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            TaskConfig cfg = new TaskConfig();
            cfg.protocol = cbx_protocol.SelectedItem.ToString();
            cfg.timeout = Convert.ToInt32(num_timeout.Value);
            cfg.monitor = ips_monitor.GetValue();
            cfg.forwards = new List<AddrInfo>();
            cfg.forwards.AddRange(forwardlist);
            cfg.id = taskId;
            cfg.backid = backId;
            cfg.backid = cfg.GetBackId();
            TaskConfigSave?.Invoke(cfg);
            this.Close();
        }

        private void TaskFrm_Load(object sender, EventArgs e)
        {
            lbox_forwards.DataSource = forwardlist;
            EditState(false);
        }
        private void EditState(bool is_edit)
        {
            lbox_forwards.Enabled = !is_edit;
            btn_edit.Enabled = !is_edit;
            btn_forward_add.Enabled = !is_edit;
            btn_forward_del.Enabled = !is_edit;

            pan_edit.Enabled = is_edit;
            btn_forward_update.Enabled = is_edit;
        }
        private void btn_forward_add_Click(object sender, EventArgs e)
        {
            var addr = new AddrInfo();
            if (forwardlist.Count > 0) {
                addr.id = forwardlist.Max(x => x.id) + 1;
            }
            else
            {
                addr.id = 1;
            }
            forwardlist.Add(addr);
            ips_forward.FillValue(addr);
            editId = addr.id;
            lbox_forwards.SelectedItem = addr;
            EditState(true);
        }

        private void btn_forward_del_Click(object sender, EventArgs e)
        {
            AddrInfo addr = forwardlist.Where(x => x.id == editId).FirstOrDefault();
            if (addr == null)
            {
                return;
            }
            forwardlist.Remove(addr);
        }

        private void lbox_forwards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_forwards.SelectedItem == null)
            {
                return;
            }
            AddrInfo addr = lbox_forwards.SelectedItem as AddrInfo;
            FillForward(addr);
        }
        private void FillForward(AddrInfo addr)
        {
            ips_forward.FillValue(addr);
            if (forwardlist.Count == 1)
            {
                backId = forwardlist[0].id;
            }
            chk_mutual.Checked = addr.id == backId;
            chk_mutual.Enabled = addr.id != backId;
            editId = addr.id;
        }
        private void btn_forward_update_Click(object sender, EventArgs e)
        {
            AddrInfo addr = forwardlist.Where(x => x.id == editId).FirstOrDefault();
            if (addr == null)
            {
                return;
            }
            int idx = forwardlist.IndexOf(addr);
            addr.UpdateValue(ips_forward.GetValue());
            if (chk_mutual.Checked)
            {
                backId = addr.id;
            }
            forwardlist.ResetItem(idx);
            //FillForward(addr);
            EditState(false);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditState(true);
        }
    }
}
