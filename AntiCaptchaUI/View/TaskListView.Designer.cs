namespace AntiCaptchaUI.View
{
    partial class TaskListView
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
            this.fastObjectListViewTask = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnTaskId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCreateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEndTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSolveTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnUsedCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnErrorId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnErrorCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnErrorDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewTask)).BeginInit();
            this.SuspendLayout();
            // 
            // fastObjectListViewTask
            // 
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnTaskId);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnStatus);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnCreateTime);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnEndTime);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnSolveTime);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnCost);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnUsedCount);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnErrorId);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnErrorCode);
            this.fastObjectListViewTask.AllColumns.Add(this.olvColumnErrorDescription);
            this.fastObjectListViewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.fastObjectListViewTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTaskId,
            this.olvColumnStatus,
            this.olvColumnCreateTime,
            this.olvColumnEndTime,
            this.olvColumnSolveTime,
            this.olvColumnCost,
            this.olvColumnUsedCount,
            this.olvColumnErrorId,
            this.olvColumnErrorCode,
            this.olvColumnErrorDescription});
            this.fastObjectListViewTask.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListViewTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListViewTask.ForeColor = System.Drawing.Color.LightGray;
            this.fastObjectListViewTask.FullRowSelect = true;
            this.fastObjectListViewTask.Location = new System.Drawing.Point(0, 0);
            this.fastObjectListViewTask.Margin = new System.Windows.Forms.Padding(2);
            this.fastObjectListViewTask.Name = "fastObjectListViewTask";
            this.fastObjectListViewTask.ShowGroups = false;
            this.fastObjectListViewTask.Size = new System.Drawing.Size(981, 565);
            this.fastObjectListViewTask.TabIndex = 0;
            this.fastObjectListViewTask.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewTask.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewTask.VirtualMode = true;
            // 
            // olvColumnTaskId
            // 
            this.olvColumnTaskId.AspectName = "TaskId";
            this.olvColumnTaskId.CellPadding = null;
            this.olvColumnTaskId.Text = "Id";
            this.olvColumnTaskId.Width = 83;
            // 
            // olvColumnStatus
            // 
            this.olvColumnStatus.AspectName = "TaskResponse.Status";
            this.olvColumnStatus.CellPadding = null;
            this.olvColumnStatus.Text = "Status";
            this.olvColumnStatus.Width = 66;
            // 
            // olvColumnCreateTime
            // 
            this.olvColumnCreateTime.AspectName = "TaskResponse.CreateTime";
            this.olvColumnCreateTime.CellPadding = null;
            this.olvColumnCreateTime.Text = "Create Time";
            this.olvColumnCreateTime.Width = 96;
            // 
            // olvColumnEndTime
            // 
            this.olvColumnEndTime.AspectName = "TaskResponse.EndTime";
            this.olvColumnEndTime.CellPadding = null;
            this.olvColumnEndTime.Text = "End Time";
            this.olvColumnEndTime.Width = 96;
            // 
            // olvColumnSolveTime
            // 
            this.olvColumnSolveTime.AspectName = "TaskResponse.SolveTime";
            this.olvColumnSolveTime.CellPadding = null;
            this.olvColumnSolveTime.Text = "SolveTime";
            this.olvColumnSolveTime.Width = 89;
            // 
            // olvColumnCost
            // 
            this.olvColumnCost.AspectName = "TaskResponse.Cost";
            this.olvColumnCost.CellPadding = null;
            this.olvColumnCost.Text = "Cost";
            this.olvColumnCost.Width = 80;
            // 
            // olvColumnUsedCount
            // 
            this.olvColumnUsedCount.AspectName = "TaskResponse.UsedCount";
            this.olvColumnUsedCount.CellPadding = null;
            this.olvColumnUsedCount.Text = "UsedCount";
            this.olvColumnUsedCount.Width = 72;
            // 
            // olvColumnErrorId
            // 
            this.olvColumnErrorId.AspectName = "TaskResponse.ErrorId";
            this.olvColumnErrorId.CellPadding = null;
            this.olvColumnErrorId.Text = "ErrorId";
            // 
            // olvColumnErrorCode
            // 
            this.olvColumnErrorCode.AspectName = "TaskResponse.ErrorCode";
            this.olvColumnErrorCode.CellPadding = null;
            this.olvColumnErrorCode.Text = "Error Code";
            this.olvColumnErrorCode.Width = 163;
            // 
            // olvColumnErrorDescription
            // 
            this.olvColumnErrorDescription.AspectName = "TaskResponse.ErrorDescription";
            this.olvColumnErrorDescription.CellPadding = null;
            this.olvColumnErrorDescription.FillsFreeSpace = true;
            this.olvColumnErrorDescription.Text = "ErrorDescription";
            this.olvColumnErrorDescription.Width = 220;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // TaskListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.fastObjectListViewTask);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskListView";
            this.Size = new System.Drawing.Size(981, 565);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView fastObjectListViewTask;
        private BrightIdeasSoftware.OLVColumn olvColumnTaskId;
        private BrightIdeasSoftware.OLVColumn olvColumnErrorCode;
        private BrightIdeasSoftware.OLVColumn olvColumnErrorDescription;
        private BrightIdeasSoftware.OLVColumn olvColumnErrorId;
        private BrightIdeasSoftware.OLVColumn olvColumnCreateTime;
        private BrightIdeasSoftware.OLVColumn olvColumnEndTime;
        private BrightIdeasSoftware.OLVColumn olvColumnStatus;
        private System.Windows.Forms.Timer timerRefresh;
        private BrightIdeasSoftware.OLVColumn olvColumnCost;
        private BrightIdeasSoftware.OLVColumn olvColumnSolveTime;
        private BrightIdeasSoftware.OLVColumn olvColumnUsedCount;
    }
}
