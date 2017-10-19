namespace AntiCaptchaUI.View
{
    partial class CaptchaListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fastObjectListViewCaptchaKeys = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBalance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnQueued = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTotalSolved = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSpeed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLoad = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStripCaptcha = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewCaptchaKeys)).BeginInit();
            this.contextMenuStripCaptcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastObjectListViewCaptchaKeys
            // 
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnKey);
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnBalance);
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnQueued);
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnTotalSolved);
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnBid);
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnSpeed);
            this.fastObjectListViewCaptchaKeys.AllColumns.Add(this.olvColumnLoad);
            this.fastObjectListViewCaptchaKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.fastObjectListViewCaptchaKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnKey,
            this.olvColumnBalance,
            this.olvColumnQueued,
            this.olvColumnTotalSolved,
            this.olvColumnBid,
            this.olvColumnSpeed,
            this.olvColumnLoad});
            this.fastObjectListViewCaptchaKeys.ContextMenuStrip = this.contextMenuStripCaptcha;
            this.fastObjectListViewCaptchaKeys.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListViewCaptchaKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListViewCaptchaKeys.ForeColor = System.Drawing.Color.LightGray;
            this.fastObjectListViewCaptchaKeys.FullRowSelect = true;
            this.fastObjectListViewCaptchaKeys.Location = new System.Drawing.Point(0, 0);
            this.fastObjectListViewCaptchaKeys.Margin = new System.Windows.Forms.Padding(2);
            this.fastObjectListViewCaptchaKeys.Name = "fastObjectListViewCaptchaKeys";
            this.fastObjectListViewCaptchaKeys.ShowGroups = false;
            this.fastObjectListViewCaptchaKeys.Size = new System.Drawing.Size(778, 592);
            this.fastObjectListViewCaptchaKeys.TabIndex = 0;
            this.fastObjectListViewCaptchaKeys.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewCaptchaKeys.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewCaptchaKeys.VirtualMode = true;
            this.fastObjectListViewCaptchaKeys.DoubleClick += new System.EventHandler(this.fastObjectListViewCaptchaKeys_DoubleClick);
            // 
            // olvColumnKey
            // 
            this.olvColumnKey.AspectName = "ClientKey";
            this.olvColumnKey.Text = "Key";
            this.olvColumnKey.Width = 250;
            // 
            // olvColumnBalance
            // 
            this.olvColumnBalance.AspectName = "AntiCaptchaBalance.Balance";
            this.olvColumnBalance.Text = "Balance";
            this.olvColumnBalance.Width = 65;
            // 
            // olvColumnQueued
            // 
            this.olvColumnQueued.AspectName = "QueuedCount";
            this.olvColumnQueued.Text = "Currently Queued";
            this.olvColumnQueued.Width = 115;
            // 
            // olvColumnTotalSolved
            // 
            this.olvColumnTotalSolved.AspectName = "TotalCount";
            this.olvColumnTotalSolved.Text = "Total Queued";
            this.olvColumnTotalSolved.Width = 100;
            // 
            // olvColumnBid
            // 
            this.olvColumnBid.AspectName = "AntiCaptchaQueueStats.Bid";
            this.olvColumnBid.Text = "Bid";
            // 
            // olvColumnSpeed
            // 
            this.olvColumnSpeed.AspectName = "AntiCaptchaQueueStats.Speed";
            this.olvColumnSpeed.Text = "Speed";
            // 
            // olvColumnLoad
            // 
            this.olvColumnLoad.AspectName = "AntiCaptchaQueueStats.ToStringLoad";
            this.olvColumnLoad.FillsFreeSpace = true;
            this.olvColumnLoad.Text = "Load";
            this.olvColumnLoad.Width = 88;
            // 
            // contextMenuStripCaptcha
            // 
            this.contextMenuStripCaptcha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripCaptcha.Name = "contextMenuStripCaptcha";
            this.contextMenuStripCaptcha.Size = new System.Drawing.Size(153, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // CaptchaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastObjectListViewCaptchaKeys);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CaptchaListView";
            this.Size = new System.Drawing.Size(778, 592);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewCaptchaKeys)).EndInit();
            this.contextMenuStripCaptcha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView fastObjectListViewCaptchaKeys;
        private BrightIdeasSoftware.OLVColumn olvColumnKey;
        private BrightIdeasSoftware.OLVColumn olvColumnBalance;
        private BrightIdeasSoftware.OLVColumn olvColumnQueued;
        private BrightIdeasSoftware.OLVColumn olvColumnTotalSolved;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCaptcha;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Timer timerRefresh;
        private BrightIdeasSoftware.OLVColumn olvColumnLoad;
        private BrightIdeasSoftware.OLVColumn olvColumnBid;
        private BrightIdeasSoftware.OLVColumn olvColumnSpeed;
    }
}
