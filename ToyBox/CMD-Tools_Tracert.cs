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
    public partial class CMD_Tools_Tracert : Form
    {
        public CMD_Tools_Tracert()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CProcessStart.PStart("cmd.exe", "/k", "tracert " + textBox1.Text, true);
            this.Dispose();
        }
    }
}
