namespace ToyBox
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cMDToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flushDNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsAktivierungSlmgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixEnviromentalVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diensteSteuerungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckerwarteschlangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diensteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenträgerverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netzwerkeinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsteuerunglegacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firefoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iISRESETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpupdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMDToolsToolStripMenuItem,
            this.systemToolsToolStripMenuItem,
            this.softwareDownloadToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cMDToolsToolStripMenuItem
            // 
            this.cMDToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLogonToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.gpupdateToolStripMenuItem,
            this.flushDNSToolStripMenuItem,
            this.iISRESETToolStripMenuItem,
            this.iPConfigToolStripMenuItem,
            this.fixEnviromentalVariablesToolStripMenuItem,
            this.windowsAktivierungSlmgrToolStripMenuItem,
            this.whoamiToolStripMenuItem});
            this.cMDToolsToolStripMenuItem.Name = "cMDToolsToolStripMenuItem";
            this.cMDToolsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.cMDToolsToolStripMenuItem.Text = "CMD-Tools";
            // 
            // changeLogonToolStripMenuItem
            // 
            this.changeLogonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.changeLogonToolStripMenuItem.Name = "changeLogonToolStripMenuItem";
            this.changeLogonToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.changeLogonToolStripMenuItem.Text = "Change Logon";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem1,
            this.disableToolStripMenuItem1,
            this.queryToolStripMenuItem});
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.changeUserToolStripMenuItem.Text = "Change User";
            // 
            // enableToolStripMenuItem1
            // 
            this.enableToolStripMenuItem1.Name = "enableToolStripMenuItem1";
            this.enableToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.enableToolStripMenuItem1.Text = "Install";
            this.enableToolStripMenuItem1.Click += new System.EventHandler(this.enableToolStripMenuItem1_Click);
            // 
            // disableToolStripMenuItem1
            // 
            this.disableToolStripMenuItem1.Name = "disableToolStripMenuItem1";
            this.disableToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.disableToolStripMenuItem1.Text = "Execute";
            this.disableToolStripMenuItem1.Click += new System.EventHandler(this.disableToolStripMenuItem1_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // flushDNSToolStripMenuItem
            // 
            this.flushDNSToolStripMenuItem.Name = "flushDNSToolStripMenuItem";
            this.flushDNSToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.flushDNSToolStripMenuItem.Text = "FlushDNS";
            this.flushDNSToolStripMenuItem.Click += new System.EventHandler(this.flushDNSToolStripMenuItem_Click);
            // 
            // iPConfigToolStripMenuItem
            // 
            this.iPConfigToolStripMenuItem.Name = "iPConfigToolStripMenuItem";
            this.iPConfigToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.iPConfigToolStripMenuItem.Text = "IPConfig";
            this.iPConfigToolStripMenuItem.Click += new System.EventHandler(this.iPConfigToolStripMenuItem_Click);
            // 
            // windowsAktivierungSlmgrToolStripMenuItem
            // 
            this.windowsAktivierungSlmgrToolStripMenuItem.Name = "windowsAktivierungSlmgrToolStripMenuItem";
            this.windowsAktivierungSlmgrToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.windowsAktivierungSlmgrToolStripMenuItem.Text = "Windows-Aktivierung slmgr";
            this.windowsAktivierungSlmgrToolStripMenuItem.Click += new System.EventHandler(this.windowsAktivierungSlmgrToolStripMenuItem_Click);
            // 
            // fixEnviromentalVariablesToolStripMenuItem
            // 
            this.fixEnviromentalVariablesToolStripMenuItem.Name = "fixEnviromentalVariablesToolStripMenuItem";
            this.fixEnviromentalVariablesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.fixEnviromentalVariablesToolStripMenuItem.Text = "Lokale Path Variable erneutern";
            this.fixEnviromentalVariablesToolStripMenuItem.Click += new System.EventHandler(this.fixEnviromentalVariablesToolStripMenuItem_Click);
            // 
            // systemToolsToolStripMenuItem
            // 
            this.systemToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerverwaltungToolStripMenuItem,
            this.diensteSteuerungToolStripMenuItem,
            this.diensteToolStripMenuItem,
            this.datenträgerverwaltungToolStripMenuItem,
            this.netzwerkeinstellungenToolStripMenuItem,
            this.systemsteuerunglegacyToolStripMenuItem});
            this.systemToolsToolStripMenuItem.Name = "systemToolsToolStripMenuItem";
            this.systemToolsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.systemToolsToolStripMenuItem.Text = "System-Tools";
            this.systemToolsToolStripMenuItem.Click += new System.EventHandler(this.systemToolsToolStripMenuItem_Click);
            // 
            // computerverwaltungToolStripMenuItem
            // 
            this.computerverwaltungToolStripMenuItem.Name = "computerverwaltungToolStripMenuItem";
            this.computerverwaltungToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.computerverwaltungToolStripMenuItem.Text = "Computerverwaltung";
            this.computerverwaltungToolStripMenuItem.Click += new System.EventHandler(this.computerverwaltungToolStripMenuItem_Click);
            // 
            // diensteSteuerungToolStripMenuItem
            // 
            this.diensteSteuerungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckerwarteschlangeToolStripMenuItem});
            this.diensteSteuerungToolStripMenuItem.Name = "diensteSteuerungToolStripMenuItem";
            this.diensteSteuerungToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.diensteSteuerungToolStripMenuItem.Text = "Dienste-Steuerung";
            // 
            // druckerwarteschlangeToolStripMenuItem
            // 
            this.druckerwarteschlangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem2,
            this.disableToolStripMenuItem2,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.druckerwarteschlangeToolStripMenuItem.Name = "druckerwarteschlangeToolStripMenuItem";
            this.druckerwarteschlangeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.druckerwarteschlangeToolStripMenuItem.Text = "Druckerwarteschlange";
            // 
            // enableToolStripMenuItem2
            // 
            this.enableToolStripMenuItem2.Name = "enableToolStripMenuItem2";
            this.enableToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem2.Text = "Enable";
            this.enableToolStripMenuItem2.Click += new System.EventHandler(this.enableToolStripMenuItem2_Click);
            // 
            // disableToolStripMenuItem2
            // 
            this.disableToolStripMenuItem2.Name = "disableToolStripMenuItem2";
            this.disableToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem2.Text = "Disable";
            this.disableToolStripMenuItem2.Click += new System.EventHandler(this.disableToolStripMenuItem2_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // diensteToolStripMenuItem
            // 
            this.diensteToolStripMenuItem.Name = "diensteToolStripMenuItem";
            this.diensteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.diensteToolStripMenuItem.Text = "Diensteverwaltung";
            this.diensteToolStripMenuItem.Click += new System.EventHandler(this.diensteToolStripMenuItem_Click);
            // 
            // datenträgerverwaltungToolStripMenuItem
            // 
            this.datenträgerverwaltungToolStripMenuItem.Name = "datenträgerverwaltungToolStripMenuItem";
            this.datenträgerverwaltungToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.datenträgerverwaltungToolStripMenuItem.Text = "Datenträgerverwaltung";
            this.datenträgerverwaltungToolStripMenuItem.Click += new System.EventHandler(this.datenträgerverwaltungToolStripMenuItem_Click);
            // 
            // netzwerkeinstellungenToolStripMenuItem
            // 
            this.netzwerkeinstellungenToolStripMenuItem.Name = "netzwerkeinstellungenToolStripMenuItem";
            this.netzwerkeinstellungenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.netzwerkeinstellungenToolStripMenuItem.Text = "Netzwerkeinstellungen";
            this.netzwerkeinstellungenToolStripMenuItem.Click += new System.EventHandler(this.netzwerkeinstellungenToolStripMenuItem_Click);
            // 
            // systemsteuerunglegacyToolStripMenuItem
            // 
            this.systemsteuerunglegacyToolStripMenuItem.Name = "systemsteuerunglegacyToolStripMenuItem";
            this.systemsteuerunglegacyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.systemsteuerunglegacyToolStripMenuItem.Text = "Systemsteuerung(legacy)";
            this.systemsteuerunglegacyToolStripMenuItem.Click += new System.EventHandler(this.systemsteuerunglegacyToolStripMenuItem_Click);
            // 
            // softwareDownloadToolStripMenuItem
            // 
            this.softwareDownloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firefoxToolStripMenuItem,
            this.chromeToolStripMenuItem});
            this.softwareDownloadToolStripMenuItem.Name = "softwareDownloadToolStripMenuItem";
            this.softwareDownloadToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.softwareDownloadToolStripMenuItem.Text = "Software-Download";
            this.softwareDownloadToolStripMenuItem.Click += new System.EventHandler(this.softwareDownloadToolStripMenuItem_Click);
            // 
            // firefoxToolStripMenuItem
            // 
            this.firefoxToolStripMenuItem.Name = "firefoxToolStripMenuItem";
            this.firefoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firefoxToolStripMenuItem.Text = "Firefox";
            this.firefoxToolStripMenuItem.Click += new System.EventHandler(this.firefoxToolStripMenuItem_Click);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chromeToolStripMenuItem.Text = "Chrome";
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.chromeToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // iISRESETToolStripMenuItem
            // 
            this.iISRESETToolStripMenuItem.Name = "iISRESETToolStripMenuItem";
            this.iISRESETToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.iISRESETToolStripMenuItem.Text = "IISRESET";
            this.iISRESETToolStripMenuItem.Click += new System.EventHandler(this.iISRESETToolStripMenuItem_Click);
            // 
            // whoamiToolStripMenuItem
            // 
            this.whoamiToolStripMenuItem.Name = "whoamiToolStripMenuItem";
            this.whoamiToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.whoamiToolStripMenuItem.Text = "whoami";
            this.whoamiToolStripMenuItem.Click += new System.EventHandler(this.whoamiToolStripMenuItem_Click);
            // 
            // gpupdateToolStripMenuItem
            // 
            this.gpupdateToolStripMenuItem.Name = "gpupdateToolStripMenuItem";
            this.gpupdateToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gpupdateToolStripMenuItem.Text = "gpupdate";
            this.gpupdateToolStripMenuItem.Click += new System.EventHandler(this.gpupdateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(347, 24);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ToyBox";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMDToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flushDNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsteuerunglegacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netzwerkeinstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diensteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenträgerverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firefoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsAktivierungSlmgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diensteSteuerungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckerwarteschlangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixEnviromentalVariablesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem iISRESETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoamiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpupdateToolStripMenuItem;
    }
}

