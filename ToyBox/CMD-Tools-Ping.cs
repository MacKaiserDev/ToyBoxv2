using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToyBox
{
    public partial class CMD_Tools_Ping : Form
    {
        public CMD_Tools_Ping()
        {
            InitializeComponent();
        }

        private bool Dauerping = false;


        #region Checkbox "/t Dauerping"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                Dauerping=true;
            }
            if(checkBox1.CheckState==CheckState.Unchecked)
            {
                Dauerping = false;
            }
        }
        #endregion

        #region Eingabe IPAdresse/Zieldomäne
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Button Ping
        private void button1_Click(object sender, EventArgs e)
        {
            string Argument = "";
            string Ziel = "";
            if (Dauerping == true)
            {
                Argument = "/t";
            }
            else
            {
                Argument = "";
            }

            Ziel = textBox1.Text;
            CProcessStart.PStart("cmd.exe", "/k", "ping " + Ziel +" "+ Argument, true);
            this.Close();
        }
        #endregion

    }
}
