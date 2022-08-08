using Newtonsoft.Json;
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
    public partial class PortMapXfrm : Form
    {
        BindingList<TaskConfig> tasklist = new BindingList<TaskConfig>();
        public PortMapXfrm()
        {
            InitializeComponent();
        }

        private void PortMapXfrm_Load(object sender, EventArgs e)
        {
            dg_tasks.AutoGenerateColumns = false;
            ConfigLoad();
        }
        private void ConfigLoad()
        {
            PMConfig pmcfg;
            string json = Properties.Settings.Default.PMConfig;
            if (string.IsNullOrWhiteSpace(json))
            {
                pmcfg = new PMConfig();
            }
            else
            {
                pmcfg = JsonConvert.DeserializeObject<PMConfig>(json);
            }
            foreach(var task in pmcfg.task_list)
            {
                tasklist.Add(task);
            }
            dg_tasks.DataSource = tasklist;
        }
        
        private void ConfigSave()
        {
            PMConfig pmcfg = new PMConfig();
            pmcfg.task_list.AddRange(tasklist);
            string json = JsonConvert.SerializeObject(pmcfg);
            Properties.Settings.Default.PMConfig = json;
            Properties.Settings.Default.Save();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            TaskConfig taskcfg = new TaskConfig();
            TaskFrm tfrm = new TaskFrm();
            tfrm.FillForm(taskcfg);
            tfrm.TaskConfigSave += Tfrm_TaskConfigSave;
            tfrm.ShowDialog();
        }

        private void Tfrm_TaskConfigSave(TaskConfig obj)
        {
            if (obj.id == 0)
            {
                if (tasklist.Count == 0)
                {
                    obj.id = 1;
                }
                else
                {
                    obj.id = tasklist.Max(x => x.id) + 1;
                }
                tasklist.Add(obj);
            }
            else
            {
                var task = tasklist.Where(x => x.id == obj.id).FirstOrDefault();
                if (task == null)
                {
                    return;
                }
                int idx = tasklist.IndexOf(task);
                task.UpdateValue(obj);
                tasklist.ResetItem(idx);
            }
            ConfigSave();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dg_tasks.SelectedRows.Count == 0)
            {
                return;
            }
            var task = dg_tasks.SelectedRows[0].DataBoundItem as TaskConfig;
            TaskFrm tfrm = new TaskFrm();
            tfrm.FillForm(task);
            tfrm.TaskConfigSave += Tfrm_TaskConfigSave;
            tfrm.ShowDialog();
        }

        private void dg_tasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_tasks.SelectedRows.Count == 0)
            {
                return;
            }
            var task = dg_tasks.SelectedRows[0].DataBoundItem as TaskConfig;
            BtnsState(task);
        }
        private void BtnsState(TaskConfig tcfg)
        {
            btn_start.Enabled = !tcfg.is_runing;
            btn_delete.Enabled = !tcfg.is_runing;
            btn_edit.Enabled = !tcfg.is_runing;

            btn_stop.Enabled = tcfg.is_runing;

            var task = tasklist.Where(x => x.id == tcfg.id).FirstOrDefault();
            if (task == null)
            {
                return;
            }
            int idx = tasklist.IndexOf(task);
            tasklist.ResetItem(idx);
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (dg_tasks.SelectedRows.Count == 0)
            {
                return;
            }
            var task = dg_tasks.SelectedRows[0].DataBoundItem as TaskConfig;


            task.ServerStop -= TaskClose;
            task.ServerStop += TaskClose;
            task.OnLogs -= TaskLogs;
            task.OnLogs += TaskLogs;
            task.Start();
            BtnsState(task);

        }
        private void TaskLogs(string log)
        {
            int maxLine = 200;
            this.Invoke(new Action(() =>
            {
                if (txt_logs.Lines.Length > maxLine)
                {
                    txt_logs.Text = txt_logs.Text.Remove(0, txt_logs.GetFirstCharIndexFromLine(txt_logs.Lines.Length - maxLine));
                }
                txt_logs.AppendText(log + Environment.NewLine);
            }));
        }
        private void TaskClose(TaskConfig task)
        {
            this.Invoke(new Action(() =>
            {
                BtnsState(task);
            }));
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (dg_tasks.SelectedRows.Count == 0)
            {
                return;
            }
            var task = dg_tasks.SelectedRows[0].DataBoundItem as TaskConfig;
            task.Stop();
            BtnsState(task);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_tasks.SelectedRows.Count == 0)
            {
                return;
            }
            var task = dg_tasks.SelectedRows[0].DataBoundItem as TaskConfig;
            tasklist.Remove(task);
            ConfigSave();
        }

        private void btn_clear_logs_Click(object sender, EventArgs e)
        {
            txt_logs.Clear();
        }
    }
}
