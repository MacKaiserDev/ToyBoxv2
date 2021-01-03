using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToyBox
{
    public partial class CMD_Tools_slmgr_EnterKey : Form
    {
        string sWindowsKey = "";
        public CMD_Tools_slmgr_EnterKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sWindowsKey = Eingabe_Win_Key.Text;

            if(sWindowsKey=="")
            {
                MessageBox.Show("Gültigen Windows Key eingeben");
            }
            else
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Verb = "runas";
                P.StartInfo.Arguments = "/k" + "slmgr.vbs -ipk "+ sWindowsKey;
                P.Start();
                System.Threading.Thread.Sleep(3000);

                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Verb = "runas";
                P.StartInfo.Arguments = "/k" + "slmgr.vbs -ato " + sWindowsKey;
                P.Start();

                this.Close();
            }


            
        }
    }
}
