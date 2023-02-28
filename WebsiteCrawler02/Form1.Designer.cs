namespace WebsiteCrawler02
{
    partial class frmMain
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
            this.btn_Crawl = new System.Windows.Forms.Button();
            this.datMain = new System.Windows.Forms.DataGridView();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.lb_dat = new System.Windows.Forms.Label();
            this.lb_Log = new System.Windows.Forms.Label();
            this.progressMain = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_choosePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.llb_copyright = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Crawl
            // 
            this.btn_Crawl.Location = new System.Drawing.Point(12, 493);
            this.btn_Crawl.Name = "btn_Crawl";
            this.btn_Crawl.Size = new System.Drawing.Size(195, 52);
            this.btn_Crawl.TabIndex = 0;
            this.btn_Crawl.Text = "Crawl";
            this.btn_Crawl.UseVisualStyleBackColor = true;
            this.btn_Crawl.Click += new System.EventHandler(this.CrawlAction);
            // 
            // datMain
            // 
            this.datMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datMain.Location = new System.Drawing.Point(10, 57);
            this.datMain.Name = "datMain";
            this.datMain.RowHeadersWidth = 51;
            this.datMain.RowTemplate.Height = 24;
            this.datMain.Size = new System.Drawing.Size(554, 348);
            this.datMain.TabIndex = 1;
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(570, 57);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(280, 348);
            this.txt_Log.TabIndex = 2;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(649, 488);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(195, 52);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // lb_dat
            // 
            this.lb_dat.AutoSize = true;
            this.lb_dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dat.Location = new System.Drawing.Point(10, 18);
            this.lb_dat.Name = "lb_dat";
            this.lb_dat.Size = new System.Drawing.Size(89, 32);
            this.lb_dat.TabIndex = 4;
            this.lb_dat.Text = "Data: ";
            this.lb_dat.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Log
            // 
            this.lb_Log.AutoSize = true;
            this.lb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Log.Location = new System.Drawing.Point(565, 18);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(91, 32);
            this.lb_Log.TabIndex = 5;
            this.lb_Log.Text = "Logs: ";
            // 
            // progressMain
            // 
            this.progressMain.Location = new System.Drawing.Point(10, 427);
            this.progressMain.Name = "progressMain";
            this.progressMain.Size = new System.Drawing.Size(834, 34);
            this.progressMain.TabIndex = 7;
            // 
            // txt_Path
            // 
            this.txt_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.Location = new System.Drawing.Point(287, 501);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(359, 34);
            this.txt_Path.TabIndex = 8;
            // 
            // btn_choosePath
            // 
            this.btn_choosePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choosePath.Location = new System.Drawing.Point(604, 499);
            this.btn_choosePath.Name = "btn_choosePath";
            this.btn_choosePath.Size = new System.Drawing.Size(41, 34);
            this.btn_choosePath.TabIndex = 9;
            this.btn_choosePath.Text = "...";
            this.btn_choosePath.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path: ";
            // 
            // llb_copyright
            // 
            this.llb_copyright.AutoSize = true;
            this.llb_copyright.Location = new System.Drawing.Point(374, 541);
            this.llb_copyright.Name = "llb_copyright";
            this.llb_copyright.Size = new System.Drawing.Size(117, 15);
            this.llb_copyright.TabIndex = 11;
            this.llb_copyright.TabStop = true;
            this.llb_copyright.Text = "@2023 Brother Team";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 565);
            this.Controls.Add(this.llb_copyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_choosePath);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.progressMain);
            this.Controls.Add(this.lb_Log);
            this.Controls.Add(this.lb_dat);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.datMain);
            this.Controls.Add(this.btn_Crawl);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Crawler by Brother Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Crawl;
        private System.Windows.Forms.DataGridView datMain;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label lb_dat;
        private System.Windows.Forms.Label lb_Log;
        private System.Windows.Forms.ProgressBar progressMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_choosePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llb_copyright;
    }
}

