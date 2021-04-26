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
        #region CMD-Tools > AD-Tools
        //Überpunkt AD-Tools Aktuell keine Funktion
        private void aDToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region CMD-Tools > AD-Tools > DCDIAG
        private void dCDIAGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prüft ob auf der Maschine der ACtive Directory Dienst installier ist. 
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                CProcessStart.PStart("cmd.exe", "/k", "dcdiag", true);
            }
            else
            {
                MessageBox.Show("Diese Maschine ist kein Domaincontroller.");
            }      
        }
        #endregion

        #region CMD-Tools > AD-Tools > netdom Query FSMO
        private void netdomQueryFSMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prüft ob auf der Maschine der ACtive Directory Dienst installier ist. 
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                CProcessStart.PStart("cmd.exe", "/k", "netdom query fsmo", true);
            }
            else
            {
                MessageBox.Show("Diese Maschine ist kein Domaincontroller.");
            }
        }
        #endregion

        #region CMD-Tools > AD-Tools > GPRESULT
        private void gPRESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prüft ob auf der Maschine der ACtive Directory Dienst installier ist. 
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                CProcessStart.PStart("cmd.exe", "/k", "gpresult /r", true);
            }
            else
            {
                MessageBox.Show("Diese Maschine ist kein Domaincontroller.");
            }
        }
        #endregion

        #region CMD-Tools > Change logon > Enable //runas
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CProcessStart.PStart("cmd.exe", "/k", "change logon /enable", true);
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
                CProcessStart.PStart("cmd.exe", "/k", "change logon /disable", true);
               
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
                CProcessStart.PStart("cmd.exe", "/k", "change user /Install", true);
    
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
                CProcessStart.PStart("cmd.exe", "/k", "change user /execute", true);
                
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
                CProcessStart.PStart("cmd.exe", "/k", "change user /query", true);
            
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > GPUPDATE //runas
        private void gpupdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CProcessStart.PStart("cmd.exe", "/k", "gpupdate /force", true);
        }
        #endregion

        #region CMD-Tools > Flushdns //runas
        private void flushDNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CProcessStart.PStart("cmd.exe", "/k", "ipconfig /flushdns", true);
            }
            catch
            {
                MessageBox.Show("Fehler");
            }

        }
        #endregion

        #region CMD-Tools > IISRESET //runas
        private void iISRESETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Win32ServiceTools.GetServiceInstallVerification("W3SVC") ==true)
            {
                CProcessStart.PStart("cmd.exe", "/k", "iisreset", true);
            }
            else
            {
                MessageBox.Show("WWW-Publishingdienst ist nicht installiert.");
            }            
        }


        #endregion

        #region CMD-Tools > IPConfig //runas
        private void iPConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CProcessStart.PStart("cmd.exe", "/k", "ipconfig /all", true);
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }
        #endregion

        #region CMD-Tools > Ping
        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMD_Tools_Ping CMDPING = new CMD_Tools_Ping();
            CMDPING.Show();
            CMDPING.Focus();
        }
        #endregion

        #region CMD-Tools > Systemneustart
        private void systemneustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CProcessStart.PStart("cmd.exe", "/k", "shutdown -r /t 0", true);
            }
            catch
            {
                MessageBox.Show("Fehler");
            }

        }

        #endregion

        #region CMD-Tools > Lokale Path Variable erneuern //runas
        private void fixEnviromentalVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Anpassungen an der Registry im Bereich HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment erfordern Administrator Rechte.\r\n ToyBox daher als Administrator starten.");
            try
            {
                
                string sKey = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
                string sPath = @"C:\WINDOWS\system32;C:\WINDOWS;C:\WINDOWS\System32\Wbem;";
                //Setzt den Default Path neu
                Registry.SetValue(sKey, "Path", sPath);
                MessageBox.Show("Lokale Path Variable mit dem Wert\r\n" + sPath + "\r\nunter " + sKey + " wurde gesetzt\r\nDamit die Änderung wirksam wird, muss der Rechner neu gestartet werden. ");
            }
            catch
            {
                MessageBox.Show("Fehler beim Setzten der lokalen Path Variable. Ursache ungekannt.");
            }

        }
        #endregion

        #region CMD-Tools > Tracert
        private void tracertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMD_Tools_Tracert Tracert = new CMD_Tools_Tracert();
            Tracert.Show();
            Tracert.Focus();
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

        #region CMD-Tools > WHOAMI //runas
        private void whoamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CProcessStart.PStart("cmd.exe", "/k", "whoami", true);
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

       

        #region System-Tools > Computerverwaltung
        private void computerverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("compmgmt.msc");

        }
        #endregion

        // Dienststeuerung Druckerwarteschlange
        #region System-Tools > Datenträgerverwaltung
        private void datenträgerverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("diskmgmt.msc");
        }
        #endregion

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

        #region System-Tools > Domain-Verwaltung > Active Directory-Benutzer und Computer
        private void activeDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                System.Diagnostics.Process.Start("DSA.msc");
            }
            else
            {
                MessageBox.Show("Dieser Rechner ist kein Domaincontroller");
            }
        }
        #endregion

        #region System-Tools > Domain-Verwaltung > Active Directory-Domänen und Vertrauensstellungen
        private void activeDirectoryDomänenUndVertreuensstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("domain.msc");
                }
                catch (Exception)
                {
                    MessageBox.Show("Active Directory-Domänen und Vertrauensstellungen ist nicht installiert oder kann nicht aufgerufen werden.");
                }

            }
            else
            {
                MessageBox.Show("Dieser Rechner ist kein Domaincontroller");
            }
        }
        #endregion

        #region System-Tools > Domain-Verwaltung > Active Directory-Standorte und Dienste
        private void activeDirectoryStandorteUndDiensteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("DSSITE.msc");
                }
                catch (Exception)
                {
                    MessageBox.Show("Active Directory-Standorte und Dienste ist nicht installiert oder kann nicht aufgerufen werden.");
                }

            }
            else
            {
                MessageBox.Show("Dieser Rechner ist kein Domaincontroller");
            }
        }
        #endregion

        #region System-Tools > Domain-Verwaltung > Active Directory-Verwaltungscenter
        private void activeDirectoryVerwaltungcenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("dsac.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("Active Directory-Verwaltungscenter ist nicht installiert oder kann nicht aufgerufen werden.");
                }

            }
            else
            {
                MessageBox.Show("Dieser Rechner ist kein Domaincontroller");
            }
        }
        #endregion

        #region System-Tools > Domain-Verwaltung > ADSI Editor
        private void aDSIEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("ADSIEDIT.msc");
                }
                catch (Exception)
                {
                    MessageBox.Show("ADSI Editor nicht installiert oder kann nicht aufgerufen werden.");
                }
                
            }
            else
            {
                MessageBox.Show("Dieser Rechner ist kein Domaincontroller");
            }
        }
        #endregion

        #region System-Tools > Domain-Verwaltung > NetDom Query FSMO

        private void netDomQueryFSMOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Win32ServiceTools.GetServiceInstallVerification("NTDS") == true)
            {
                try
                {
                    CProcessStart.PStart("cmd.exe", "/k", "netdom query fsmo", true);
                }
                catch (Exception)
                {
                    MessageBox.Show("ADSI Editor nicht installiert oder kann nicht aufgerufen werden.");
                }

            }
            else
            {
                MessageBox.Show("Dieser Rechner ist kein Domaincontroller");
            }
        }
        #endregion

        #region System-Tools > Sicherheitsrichtlinien > Lokal
        private void lokalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("secpol.msc");
        }
        #endregion

        #region System-Tools > Sicherheitsrichtlinien > Domäne
        private void domäneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("GPmc.msc");
        }
        #endregion

        #region System-Tools > Netzwerkadaptereinstellungen
        private void netzwerkeinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe", "NCPA.CPL");
        }
        #endregion

        #region System-Tools > Regedit
        private void regeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CProcessStart.PStart("regedit.exe");
        }
        #endregion

        #region System-Tools > Systemsteuerung
        private void systemsteuerunglegacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CProcessStart.PStart("control.exe");
        }
        #endregion

        #region System-Tools > Systemsteuerung > Mail-Konten
        private void mailKontenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe", "MLCFG32.CPL");
        }
        #endregion

        #region System-Tools > Windwos Firewall
        private void windowsFirewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe", "FIREWALL.CPL");

        }
        #endregion


        #region System-Tools > Windwos Update
        private void windowsUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control", "/name Microsoft.WindowsUpdate");

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

        #region Software-Tools > Advanced IP Scanner
        private void advancedIPScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Teamviewer an dieser Stelle. 
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            string Zieldatei_Advanced_IP_Scanner = "Advanced_IP_Scanner.exe";
            string Zielpfad = path + @"\" + Zieldatei_Advanced_IP_Scanner;

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("http://itskk.de/Upload/Advanced_IP_Scanner.exe"), Zielpfad);
            //Process.Start(path);

            MessageBox.Show("Advanced IP Scanner wird heruntergeladen. Die Datei wurde unter: " + Zielpfad + " abgelegt. ");
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
            MessageBox.Show("Chrome wird heruntergeladen. Die Datei wurde unter: " + Zielpfad + " abgelegt. ");
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

            MessageBox.Show("Firefox wird heruntergeladen. Die Datei wurde unter: "+ Zielpfad + " abgelegt. ");
        }
        #endregion

        #region Software-Download > SMTP-Tool
        private void sMTPToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Teamviewer an dieser Stelle. 
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            string Zieldatei_SMTPTool = "SMTPTool.zip";
            string Zielpfad = path + @"\" + Zieldatei_SMTPTool;

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("http://itskk.de/Upload/SMTPTool.zip"), Zielpfad);
            //Process.Start(path);

            MessageBox.Show("SMTPTool.zip wird heruntergeladen. Die Datei wurde unter: " + Zielpfad + " abgelegt. ");
        }
        #endregion

        #region Software-Tools > Teamviewer QS
        private void teamviewerQSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Teamviewer an dieser Stelle. 
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            string Zieldatei_TeamviewerQS = "Teamviewer_QS.exe";
            string Zielpfad = path + @"\" + Zieldatei_TeamviewerQS;

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("http://itskk.de/Upload/TeamViewerQS.exe"), Zielpfad);
            //Process.Start(path);

            MessageBox.Show("Teamviewer QS wird heruntergeladen. Die Datei wurde unter: " + Zielpfad + " abgelegt. ");
        }
        #endregion

        #region Software-Tools > Teamviewer Host
        private void teamviewerHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Teamviewer an dieser Stelle. 
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            string Zieldatei_TeamviewerHost = "Teamviewer_Host.exe";
            string Zielpfad = path + @"\" + Zieldatei_TeamviewerHost;

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("http://itskk.de/Upload/TeamViewer_Host_Setup.exe"), Zielpfad);
            //Process.Start(path);

            MessageBox.Show("Teamviewer Host wird heruntergeladen. Die Datei wurde unter: " + Zielpfad + " abgelegt. ");
        }
        #endregion

        #region Software-Tools > TreeSize Free
        private void treeSizeFreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liest den Downloads Ordner des aktuellen Users aus und speichert den Download von Teamviewer an dieser Stelle. 
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            string Zieldatei_TreeSize = "TreeSizeFreeSetup.exe";
            string Zielpfad = path + @"\" + Zieldatei_TreeSize;

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(new System.Uri("http://itskk.de/Upload/TreeSizeFreeSetup.exe"), Zielpfad);
            //Process.Start(path);

            MessageBox.Show("TTreeSize Free wird heruntergeladen. Die Datei wurde unter: " + Zielpfad + " abgelegt. ");
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
