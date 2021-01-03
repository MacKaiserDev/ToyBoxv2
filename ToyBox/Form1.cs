using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.ServiceProcess;
using Microsoft.Win32;

namespace ToyBox
{
    public partial class Form1 : Form
    {
        //Globale Variablen        
        public string slmgr_Win_key = ""; // Findet verwendung unter "CMD-Tools > Windows Aktivierung slmgr

        public Form1()
        {
            InitializeComponent();
            
        }

        /*
        --------------------------------------------------------------------------
        Benüpunkt CMD-Tools
        --------------------------------------------------------------------------
        */

        #region CMD-Tools > IPConfig //runas
        private void iPConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.UseShellExecute = true;
                P.StartInfo.Arguments = "/k" + "ipconfig /all";
                //P.StartInfo.Verb = "runas /trustlevel:Administrator";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Flushdns //runas
        private void flushDNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Arguments = "/k" + "ipconfig /flushdns";
                P.StartInfo.Verb = "runas";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
         
        }
        #endregion

        #region CMD-Tools > Change logon > Enable //runas
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Arguments = "/k" + "change logon /enable";
                P.StartInfo.Verb = "runas";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Change logon > Disable  //runas
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Arguments = "/k" + "change logon /disable";
                P.StartInfo.Verb = "runas";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Change User /install //runas
        private void enableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Arguments = "/k" + "change user /Install";
                P.StartInfo.Verb = "runas";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Change User /execute//runas
        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Arguments = "/k" + "change user /execute";
                P.StartInfo.Verb = "runas";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Change User /Querry //runas
        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process P = new Process();
                P.StartInfo.FileName = "cmd.exe";
                P.StartInfo.CreateNoWindow = false;
                P.StartInfo.Arguments = "/k" + "change user /query";
                P.StartInfo.Verb = "runas";
                P.Start();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Windows-Aktivierung slmgr //runas
        private void windowsAktivierungSlmgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMD_Tools_slmgr_EnterKey EK = new CMD_Tools_slmgr_EnterKey();
            EK.Show();
            EK.Focus();
        }
        #endregion

        #region CMD-Tools > Fix Enviromental Variables //runas
        private void fixEnviromentalVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sKey = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
                string sPath = @"C:\WINDOWS\system32;C:\WINDOWS;C:\WINDOWS\System32\Wbem;";
                //Setzt den Default Path neu
                Registry.SetValue(sKey, "Path", sPath);
                MessageBox.Show("Lokale Path Variable mit dem Wert" + sPath + " unter " + sKey + " wurde gesetzt");
            }
            catch
            {
                MessageBox.Show("Fehler beim Setzten der lokalen Path Variable Ursache ungekannt.");
            }
            
        }
        #endregion

        /*
        --------------------------------------------------------------------------
        Benüpunkt System-Tools
        --------------------------------------------------------------------------
        */

        #region Überpunkt System-Tools
        private void systemToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Überpunkt System-Tools wird nicht benötigt
        }
        #endregion

        #region System-Tools > Systemsteuerung
        private void systemsteuerunglegacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process P = new Process();
            P.StartInfo.FileName = "control.exe";
            P.StartInfo.CreateNoWindow = false;
            
            P.Start();
        }
        #endregion

        #region System-Tools > Computerverwaltung
        private void computerverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("compmgmt.msc");

        }
        #endregion

        // Dienststeuerung Druckerwarteschlange
        #region System-Tools > Dienstesteuerung > Druckerwarteschlange Enable
        private void enableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #region System-Tools > Dienstesteuerung > Druckerwarteschlange Disable

        private void disableToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region System-Tools > Dienstesteuerung > Druckerwarteschlange Start
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region System-Tools > Dienstesteuerung > Druckerwarteschlange Stopp

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Service = new ServiceController("Spooler");
            
            Service.Stop();
        }

        #endregion

        #region System-Tools > Dienste
        private void diensteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("services.msc");
        }
        #endregion

        #region System-Tools > Datenträgerverwaltung
        private void datenträgerverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("diskmgmt.msc");
        }
        #endregion

        #region System-Tools > Netzwerkadaptereinstellungen
        private void netzwerkeinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe", "NCPA.CPL");
        }
        #endregion

        /*
        --------------------------------------------------------------------------
        Menüpunkt Software Downloads
        --------------------------------------------------------------------------
        */

        #region Software-Downloads
        private void softwareDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Überpunkt Software-Downloads wird nicht benötigt
        }
        #endregion

        #region Software-Download > Firefox
        private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Firefox an dieser Stelle. 
            string path= Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
            
            string Zieldatei_Firefox = "Mozilla_Firefox_85.0.exe";
            string Zielpfad = path+ @"\" + Zieldatei_Firefox;

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("https://ftp.mozilla.org/pub/firefox/releases/84.0/win64/de/Firefox%20Setup%2084.0.exe"), Zielpfad);
            //Process.Start(path);

            MessageBox.Show("Firefox wird heruntergeladen. Die Datei wurde unter "+ Zielpfad + " abgelegt. ");
        }
        #endregion

        #region Software-Download > Chrome
        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Firefox an dieser Stelle. 
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            string Zieldatei_Chrome = "Google_Chrome.exe";
            string Zielpfad = path + @"\" + Zieldatei_Chrome;
            

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("http://itskk.de/Upload/ChromeSetup.exe"), Zielpfad);
            
            //Process.Start(path);
            MessageBox.Show("Chrome wird heruntergeladen. Die Datei wurde unter " + Zielpfad + " abgelegt. ");
        }
        #endregion

        /*
       --------------------------------------------------------------------------
       Menüpunkt Hilfe
       --------------------------------------------------------------------------
       */
        #region Hife > Info
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info InfoForm = new Info();
            InfoForm.Show();
            InfoForm.Focus();
        }







        #endregion

    }
}
