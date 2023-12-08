using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Power_Menu_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        [DllImport("PowrProf.dll", SetLastError = true)]
        public static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        string title = "Power Menu V1";
        string processName = "Chrome";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = title;
        }

        private void rjButton1_Click(object sender, EventArgs e) //Shutdown
        {
            Process[] process = Process.GetProcessesByName(processName);
            if (checkBox1.Checked == true)
            {
                DialogResult result = MessageBox.Show("Your PC will be Fully Shutdown.\nAre you sure?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    if (process.Length > 0)
                    {
                        DialogResult result11 = MessageBox.Show(processName + " is running.\nAre you sure?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result11 == DialogResult.Yes)
                        {
                            Process.Start("shutdown", "-s -t 0");
                            Process.GetCurrentProcess().Kill();
                        }
                        else if(result11 == DialogResult.No)
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    else
                    {
                        Process.Start("shutdown", "-s -t 0");
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            else if(checkBox1.Checked == false)
            {
                if(process.Length > 0)
                {
                    DialogResult result = MessageBox.Show(processName + " is running.\nAre you sure?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Process.Start("shutdown", "-s -hybrid -t 0");
                        Process.GetCurrentProcess().Kill();
                    }
                    else if(result == DialogResult.No)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
                else
                {
                    Process.Start("shutdown", "-s -hybrid -t 0");
                    Process.GetCurrentProcess().Kill();
                }
                
            }
        }

        private void rjButton2_Click(object sender, EventArgs e) //Restart
        {
            Process[] process = Process.GetProcessesByName(processName);
            if (process.Length > 0)
            {
                DialogResult result = MessageBox.Show(processName + " is running.\nAre you sure?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Process.Start("shutdown", "-r -t 0");
                    Process.GetCurrentProcess().Kill();
                }
                else if (result == DialogResult.No)
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            else
            {
                Process.Start("shutdown", "-r -t 0");
                Process.GetCurrentProcess().Kill();
            }
            
        }

        private void rjButton3_Click(object sender, EventArgs e) //Signout
        {
            Process[] process = Process.GetProcessesByName(processName);
            if (process.Length > 0)
            {
                DialogResult result = MessageBox.Show(processName + " is running.\nAre you sure?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Process.Start("shutdown", "-l");
                    Process.GetCurrentProcess().Kill();
                }
                else if(result == DialogResult.No)
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            else
            {
                Process.Start("shutdown", "-l");
                Process.GetCurrentProcess().Kill();
            }
            
        }

        private void rjButton4_Click(object sender, EventArgs e) //Sleep
        {
            SetSuspendState(false, false, false);
            Process.GetCurrentProcess().Kill();
        }

        private void rjButton5_Click(object sender, EventArgs e) //Hibernate
        {
            SetSuspendState(true, true, true);
            Process.GetCurrentProcess().Kill();
        }

        private void rjButton6_Click(object sender, EventArgs e) //info
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        
    }
}
