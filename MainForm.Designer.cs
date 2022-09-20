
namespace ShatterlineProxy {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TxtLog = new System.Windows.Forms.RichTextBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mongooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orbitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.malvaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TabProxy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CheckMobGrenade = new System.Windows.Forms.CheckBox();
            this.CheckUnreleasedLMG = new System.Windows.Forms.CheckBox();
            this.CheckUnreleasedOutfit = new System.Windows.Forms.CheckBox();
            this.CheckMaxWeaponProgression = new System.Windows.Forms.CheckBox();
            this.CheckUnlockAll = new System.Windows.Forms.CheckBox();
            this.TabProxy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(0, 0);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(1069, 369);
            this.TxtLog.TabIndex = 0;
            this.TxtLog.Text = "";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(3, 373);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(1060, 33);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop Proxy";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // malvaToolStripMenuItem
            // 
            this.malvaToolStripMenuItem.Name = "malvaToolStripMenuItem";
            this.malvaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pillToolStripMenuItem
            // 
            this.pillToolStripMenuItem.Name = "pillToolStripMenuItem";
            this.pillToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mongooseToolStripMenuItem
            // 
            this.mongooseToolStripMenuItem.Name = "mongooseToolStripMenuItem";
            this.mongooseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // orbitToolStripMenuItem
            // 
            this.orbitToolStripMenuItem.Name = "orbitToolStripMenuItem";
            this.orbitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // strixToolStripMenuItem
            // 
            this.strixToolStripMenuItem.Name = "strixToolStripMenuItem";
            this.strixToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // kiteToolStripMenuItem
            // 
            this.kiteToolStripMenuItem.Name = "kiteToolStripMenuItem";
            this.kiteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // charactersToolStripMenuItem1
            // 
            this.charactersToolStripMenuItem1.Name = "charactersToolStripMenuItem1";
            this.charactersToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // malvaToolStripMenuItem1
            // 
            this.malvaToolStripMenuItem1.Name = "malvaToolStripMenuItem1";
            this.malvaToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // TabProxy
            // 
            this.TabProxy.Controls.Add(this.tabPage1);
            this.TabProxy.Controls.Add(this.tabPage2);
            this.TabProxy.Location = new System.Drawing.Point(12, 2);
            this.TabProxy.Name = "TabProxy";
            this.TabProxy.SelectedIndex = 0;
            this.TabProxy.Size = new System.Drawing.Size(1077, 436);
            this.TabProxy.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnStop);
            this.tabPage1.Controls.Add(this.TxtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1069, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proxy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CheckMobGrenade);
            this.tabPage2.Controls.Add(this.CheckUnreleasedLMG);
            this.tabPage2.Controls.Add(this.CheckUnreleasedOutfit);
            this.tabPage2.Controls.Add(this.CheckMaxWeaponProgression);
            this.tabPage2.Controls.Add(this.CheckUnlockAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1069, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CheckMobGrenade
            // 
            this.CheckMobGrenade.AutoSize = true;
            this.CheckMobGrenade.Location = new System.Drawing.Point(17, 61);
            this.CheckMobGrenade.Name = "CheckMobGrenade";
            this.CheckMobGrenade.Size = new System.Drawing.Size(136, 17);
            this.CheckMobGrenade.TabIndex = 5;
            this.CheckMobGrenade.Text = "Mob Spawner Grenade";
            this.CheckMobGrenade.UseVisualStyleBackColor = true;
            this.CheckMobGrenade.CheckedChanged += new System.EventHandler(this.CheckMobGrenade_CheckedChanged);
            // 
            // CheckUnreleasedLMG
            // 
            this.CheckUnreleasedLMG.AutoSize = true;
            this.CheckUnreleasedLMG.Location = new System.Drawing.Point(173, 38);
            this.CheckUnreleasedLMG.Name = "CheckUnreleasedLMG";
            this.CheckUnreleasedLMG.Size = new System.Drawing.Size(106, 17);
            this.CheckUnreleasedLMG.TabIndex = 4;
            this.CheckUnreleasedLMG.Text = "Unreleased LMG";
            this.CheckUnreleasedLMG.UseVisualStyleBackColor = true;
            this.CheckUnreleasedLMG.CheckedChanged += new System.EventHandler(this.CheckUnreleasedLMG_CheckedChanged);
            // 
            // CheckUnreleasedOutfit
            // 
            this.CheckUnreleasedOutfit.AutoSize = true;
            this.CheckUnreleasedOutfit.Location = new System.Drawing.Point(173, 15);
            this.CheckUnreleasedOutfit.Name = "CheckUnreleasedOutfit";
            this.CheckUnreleasedOutfit.Size = new System.Drawing.Size(108, 17);
            this.CheckUnreleasedOutfit.TabIndex = 3;
            this.CheckUnreleasedOutfit.Text = "Unreleased Outfit";
            this.CheckUnreleasedOutfit.UseVisualStyleBackColor = true;
            this.CheckUnreleasedOutfit.CheckedChanged += new System.EventHandler(this.CheckUnreleasedOutfit_CheckedChanged);
            // 
            // CheckMaxWeaponProgression
            // 
            this.CheckMaxWeaponProgression.AutoSize = true;
            this.CheckMaxWeaponProgression.Location = new System.Drawing.Point(17, 15);
            this.CheckMaxWeaponProgression.Name = "CheckMaxWeaponProgression";
            this.CheckMaxWeaponProgression.Size = new System.Drawing.Size(148, 17);
            this.CheckMaxWeaponProgression.TabIndex = 1;
            this.CheckMaxWeaponProgression.Text = "Max Weapon Progression";
            this.CheckMaxWeaponProgression.UseVisualStyleBackColor = true;
            this.CheckMaxWeaponProgression.CheckedChanged += new System.EventHandler(this.CheckMaxWeaponProgression_CheckedChanged);
            // 
            // CheckUnlockAll
            // 
            this.CheckUnlockAll.AutoSize = true;
            this.CheckUnlockAll.Location = new System.Drawing.Point(17, 38);
            this.CheckUnlockAll.Name = "CheckUnlockAll";
            this.CheckUnlockAll.Size = new System.Drawing.Size(74, 17);
            this.CheckUnlockAll.TabIndex = 0;
            this.CheckUnlockAll.Text = "Unlock All";
            this.CheckUnlockAll.UseVisualStyleBackColor = true;
            this.CheckUnlockAll.CheckedChanged += new System.EventHandler(this.CheckUnlockAll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.TabProxy);
            this.Name = "MainForm";
            this.Text = "Shatterline Proxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabProxy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtLog;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mongooseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orbitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem malvaToolStripMenuItem1;
        private System.Windows.Forms.TabControl TabProxy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox CheckMaxWeaponProgression;
        private System.Windows.Forms.CheckBox CheckUnlockAll;
        private System.Windows.Forms.CheckBox CheckUnreleasedLMG;
        private System.Windows.Forms.CheckBox CheckUnreleasedOutfit;
        private System.Windows.Forms.CheckBox CheckMobGrenade;
    }
}

