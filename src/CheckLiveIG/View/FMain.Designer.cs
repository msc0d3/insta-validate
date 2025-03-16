namespace CheckLiveIG.View
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lbtimerun = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtriesC = new System.Windows.Forms.Label();
            this.lbdieC = new System.Windows.Forms.Label();
            this.lbliveC = new System.Windows.Forms.Label();
            this.lbaccC = new System.Windows.Forms.Label();
            this.lbprxC = new System.Windows.Forms.Label();
            this.btnimportdata = new System.Windows.Forms.Button();
            this.btnimportproxy = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnresultFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbapiver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numthreads = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tmupdatecount = new System.Windows.Forms.Timer(this.components);
            this.lbunkC = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numthreads)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.lbtimerun});
            this.toolStrip1.Location = new System.Drawing.Point(0, 216);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(211, 22);
            this.toolStripLabel1.Text = "@2025 tienichmmo.net | privatedware";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Time Elapsed";
            // 
            // lbtimerun
            // 
            this.lbtimerun.Name = "lbtimerun";
            this.lbtimerun.Size = new System.Drawing.Size(14, 22);
            this.lbtimerun.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbunkC);
            this.groupBox1.Controls.Add(this.lbtriesC);
            this.groupBox1.Controls.Add(this.lbdieC);
            this.groupBox1.Controls.Add(this.lbliveC);
            this.groupBox1.Controls.Add(this.lbaccC);
            this.groupBox1.Controls.Add(this.lbprxC);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lbtriesC
            // 
            this.lbtriesC.AutoSize = true;
            this.lbtriesC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbtriesC.Location = new System.Drawing.Point(6, 99);
            this.lbtriesC.Name = "lbtriesC";
            this.lbtriesC.Size = new System.Drawing.Size(58, 15);
            this.lbtriesC.TabIndex = 4;
            this.lbtriesC.Text = "Retries : 0";
            // 
            // lbdieC
            // 
            this.lbdieC.AutoSize = true;
            this.lbdieC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbdieC.Location = new System.Drawing.Point(6, 79);
            this.lbdieC.Name = "lbdieC";
            this.lbdieC.Size = new System.Drawing.Size(41, 15);
            this.lbdieC.TabIndex = 3;
            this.lbdieC.Text = "Die : 0";
            // 
            // lbliveC
            // 
            this.lbliveC.AutoSize = true;
            this.lbliveC.ForeColor = System.Drawing.Color.Green;
            this.lbliveC.Location = new System.Drawing.Point(6, 59);
            this.lbliveC.Name = "lbliveC";
            this.lbliveC.Size = new System.Drawing.Size(44, 15);
            this.lbliveC.TabIndex = 2;
            this.lbliveC.Text = "Live : 0";
            // 
            // lbaccC
            // 
            this.lbaccC.AutoSize = true;
            this.lbaccC.Location = new System.Drawing.Point(6, 39);
            this.lbaccC.Name = "lbaccC";
            this.lbaccC.Size = new System.Drawing.Size(73, 15);
            this.lbaccC.TabIndex = 1;
            this.lbaccC.Text = "Accounts : 0";
            // 
            // lbprxC
            // 
            this.lbprxC.AutoSize = true;
            this.lbprxC.Location = new System.Drawing.Point(6, 19);
            this.lbprxC.Name = "lbprxC";
            this.lbprxC.Size = new System.Drawing.Size(61, 15);
            this.lbprxC.TabIndex = 0;
            this.lbprxC.Text = "Proxies : 0";
            // 
            // btnimportdata
            // 
            this.btnimportdata.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnimportdata.FlatAppearance.BorderSize = 2;
            this.btnimportdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimportdata.Location = new System.Drawing.Point(111, 61);
            this.btnimportdata.Name = "btnimportdata";
            this.btnimportdata.Size = new System.Drawing.Size(93, 34);
            this.btnimportdata.TabIndex = 29;
            this.btnimportdata.Text = "Import Data";
            this.btnimportdata.UseVisualStyleBackColor = true;
            this.btnimportdata.Click += new System.EventHandler(this.btnimportdata_Click);
            // 
            // btnimportproxy
            // 
            this.btnimportproxy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnimportproxy.FlatAppearance.BorderSize = 2;
            this.btnimportproxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimportproxy.Location = new System.Drawing.Point(111, 21);
            this.btnimportproxy.Name = "btnimportproxy";
            this.btnimportproxy.Size = new System.Drawing.Size(93, 34);
            this.btnimportproxy.TabIndex = 30;
            this.btnimportproxy.Text = "Import Proxy";
            this.btnimportproxy.UseVisualStyleBackColor = true;
            this.btnimportproxy.Click += new System.EventHandler(this.btnimportproxy_Click);
            // 
            // btnstop
            // 
            this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
            this.btnstop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstop.Location = new System.Drawing.Point(12, 61);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(93, 34);
            this.btnstop.TabIndex = 32;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.Image = ((System.Drawing.Image)(resources.GetObject("btnstart.Image")));
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstart.Location = new System.Drawing.Point(12, 21);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(93, 34);
            this.btnstart.TabIndex = 31;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnresultFolder
            // 
            this.btnresultFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnresultFolder.Image")));
            this.btnresultFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresultFolder.Location = new System.Drawing.Point(12, 101);
            this.btnresultFolder.Name = "btnresultFolder";
            this.btnresultFolder.Size = new System.Drawing.Size(192, 34);
            this.btnresultFolder.TabIndex = 33;
            this.btnresultFolder.Text = "Result Folder";
            this.btnresultFolder.UseVisualStyleBackColor = true;
            this.btnresultFolder.Click += new System.EventHandler(this.btnresultFolder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbapiver);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numthreads);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 67);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // cbbapiver
            // 
            this.cbbapiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbapiver.FormattingEnabled = true;
            this.cbbapiver.Items.AddRange(new object[] {
            "API 1 - W",
            "API 2 - ADR"});
            this.cbbapiver.Location = new System.Drawing.Point(85, 38);
            this.cbbapiver.Name = "cbbapiver";
            this.cbbapiver.Size = new System.Drawing.Size(101, 23);
            this.cbbapiver.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "API";
            // 
            // numthreads
            // 
            this.numthreads.Location = new System.Drawing.Point(9, 37);
            this.numthreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numthreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numthreads.Name = "numthreads";
            this.numthreads.Size = new System.Drawing.Size(58, 23);
            this.numthreads.TabIndex = 1;
            this.numthreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Threads";
            // 
            // tmupdatecount
            // 
            this.tmupdatecount.Tick += new System.EventHandler(this.tmupdatecount_Tick);
            // 
            // lbunkC
            // 
            this.lbunkC.AutoSize = true;
            this.lbunkC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbunkC.Location = new System.Drawing.Point(6, 118);
            this.lbunkC.Name = "lbunkC";
            this.lbunkC.Size = new System.Drawing.Size(74, 15);
            this.lbunkC.TabIndex = 5;
            this.lbunkC.Text = "Unknown : 0";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnresultFolder);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnimportdata);
            this.Controls.Add(this.btnimportproxy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Live Instagram v1.0.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numthreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbprxC;
        private System.Windows.Forms.Label lbaccC;
        private System.Windows.Forms.Label lbtriesC;
        private System.Windows.Forms.Label lbdieC;
        private System.Windows.Forms.Label lbliveC;
        private System.Windows.Forms.Button btnimportdata;
        private System.Windows.Forms.Button btnimportproxy;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnresultFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numthreads;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbapiver;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lbtimerun;
        private System.Windows.Forms.Timer tmupdatecount;
        private System.Windows.Forms.Label lbunkC;
    }
}

