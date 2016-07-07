namespace JobBoard
{
    partial class formJobs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJobs));
            this.dataJobs = new System.Windows.Forms.DataGridView();
            this.stripStatus = new System.Windows.Forms.StatusStrip();
            this.stripStatus_Label01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_NewJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataJobs)).BeginInit();
            this.stripStatus.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataJobs
            // 
            this.dataJobs.AllowUserToAddRows = false;
            this.dataJobs.AllowUserToDeleteRows = false;
            this.dataJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataJobs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJobs.Location = new System.Drawing.Point(12, 28);
            this.dataJobs.Name = "dataJobs";
            this.dataJobs.Size = new System.Drawing.Size(1050, 242);
            this.dataJobs.TabIndex = 0;
            this.dataJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJobs_CellContentClick);
            this.dataJobs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJobs_CellValueChanged);
            // 
            // stripStatus
            // 
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus_Label01,
            this.toolStripSplitButton1});
            this.stripStatus.Location = new System.Drawing.Point(0, 273);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(1074, 22);
            this.stripStatus.TabIndex = 1;
            this.stripStatus.Text = "statusStrip1";
            // 
            // stripStatus_Label01
            // 
            this.stripStatus_Label01.Name = "stripStatus_Label01";
            this.stripStatus_Label01.Size = new System.Drawing.Size(1002, 17);
            this.stripStatus_Label01.Spring = true;
            this.stripStatus_Label01.Text = "No Database Connection";
            this.stripStatus_Label01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownButtonWidth = 10;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutesToolStripMenuItem,
            this.minuteToolStripMenuItem,
            this.secondsToolStripMenuItem1,
            this.secondsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(61, 20);
            this.toolStripSplitButton1.Text = "Refresh";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "30",
            "60",
            "300"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // bToolStripMenuItem1
            // 
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem1.Text = "b";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem1.Text = "a";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem.Text = "b";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem.Text = "a";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Manual";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // secondsToolStripMenuItem
            // 
            this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            this.secondsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.secondsToolStripMenuItem.Text = "5 seconds";
            this.secondsToolStripMenuItem.Click += new System.EventHandler(this.secondsToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem1
            // 
            this.secondsToolStripMenuItem1.Name = "secondsToolStripMenuItem1";
            this.secondsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.secondsToolStripMenuItem1.Text = "30 seconds";
            this.secondsToolStripMenuItem1.Click += new System.EventHandler(this.secondsToolStripMenuItem1_Click);
            // 
            // minuteToolStripMenuItem
            // 
            this.minuteToolStripMenuItem.Name = "minuteToolStripMenuItem";
            this.minuteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minuteToolStripMenuItem.Text = "1 minute";
            this.minuteToolStripMenuItem.Click += new System.EventHandler(this.minuteToolStripMenuItem_Click);
            // 
            // minutesToolStripMenuItem
            // 
            this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
            this.minutesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minutesToolStripMenuItem.Text = "5 minutes";
            this.minutesToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 30000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_NewJob,
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1074, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // toolStripButton_NewJob
            // 
            this.toolStripButton_NewJob.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_NewJob.Image")));
            this.toolStripButton_NewJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_NewJob.Name = "toolStripButton_NewJob";
            this.toolStripButton_NewJob.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_NewJob.Text = "New Job";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // formJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 295);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.stripStatus);
            this.Controls.Add(this.dataJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formJobs";
            this.Text = "Hosted Services Job Tracker";
            this.Load += new System.EventHandler(this.formJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataJobs)).EndInit();
            this.stripStatus.ResumeLayout(false);
            this.stripStatus.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataJobs;
        private System.Windows.Forms.StatusStrip stripStatus;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus_Label01;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_NewJob;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

