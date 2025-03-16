namespace CheckLiveIG.View
{
    partial class FrmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImport));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btncacel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.lbimported = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnfile = new System.Windows.Forms.Button();
            this.btnclipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 192);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(295, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 179;
            // 
            // btncacel
            // 
            this.btncacel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncacel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncacel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncacel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncacel.Location = new System.Drawing.Point(165, 117);
            this.btncacel.Name = "btncacel";
            this.btncacel.Size = new System.Drawing.Size(142, 34);
            this.btncacel.TabIndex = 178;
            this.btncacel.Text = "Cancel";
            this.btncacel.UseVisualStyleBackColor = true;
            this.btncacel.Click += new System.EventHandler(this.btncacel_Click);
            // 
            // btnok
            // 
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.Location = new System.Drawing.Point(11, 117);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(142, 34);
            this.btnok.TabIndex = 177;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lbimported
            // 
            this.lbimported.AutoSize = true;
            this.lbimported.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimported.Location = new System.Drawing.Point(92, 170);
            this.lbimported.Name = "lbimported";
            this.lbimported.Size = new System.Drawing.Size(14, 15);
            this.lbimported.TabIndex = 176;
            this.lbimported.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 175;
            this.label10.Text = "Data Loaded :";
            // 
            // btnfile
            // 
            this.btnfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfile.Image = ((System.Drawing.Image)(resources.GetObject("btnfile.Image")));
            this.btnfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfile.Location = new System.Drawing.Point(12, 59);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(296, 34);
            this.btnfile.TabIndex = 174;
            this.btnfile.Text = "From File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btnclipboard
            // 
            this.btnclipboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnclipboard.Image")));
            this.btnclipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclipboard.Location = new System.Drawing.Point(12, 19);
            this.btnclipboard.Name = "btnclipboard";
            this.btnclipboard.Size = new System.Drawing.Size(296, 34);
            this.btnclipboard.TabIndex = 173;
            this.btnclipboard.Text = "From Copied Text";
            this.btnclipboard.UseVisualStyleBackColor = true;
            this.btnclipboard.Click += new System.EventHandler(this.btnclipboard_Click);
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 234);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btncacel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbimported);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnclipboard);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Data";
            this.Load += new System.EventHandler(this.FrmImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btncacel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbimported;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btnclipboard;
    }
}