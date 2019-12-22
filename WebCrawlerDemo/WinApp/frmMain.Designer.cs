namespace WinApp
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
            this.tcCrawl = new System.Windows.Forms.TabControl();
            this.tpCrawl1 = new System.Windows.Forms.TabPage();
            this.btnCrawl1 = new System.Windows.Forms.Button();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.tbLocation1 = new System.Windows.Forms.TextBox();
            this.dgData1 = new System.Windows.Forms.DataGridView();
            this.tpCrawl2 = new System.Windows.Forms.TabPage();
            this.btnCrawl2 = new System.Windows.Forms.Button();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.dgData2 = new System.Windows.Forms.DataGridView();
            this.tbLocation2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcCrawl.SuspendLayout();
            this.tpCrawl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData1)).BeginInit();
            this.tpCrawl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCrawl
            // 
            this.tcCrawl.Controls.Add(this.tpCrawl1);
            this.tcCrawl.Controls.Add(this.tpCrawl2);
            this.tcCrawl.Location = new System.Drawing.Point(12, 33);
            this.tcCrawl.Name = "tcCrawl";
            this.tcCrawl.SelectedIndex = 0;
            this.tcCrawl.Size = new System.Drawing.Size(588, 404);
            this.tcCrawl.TabIndex = 0;
            // 
            // tpCrawl1
            // 
            this.tpCrawl1.Controls.Add(this.btnCrawl1);
            this.tpCrawl1.Controls.Add(this.btnChoose1);
            this.tpCrawl1.Controls.Add(this.tbLocation1);
            this.tpCrawl1.Controls.Add(this.dgData1);
            this.tpCrawl1.Location = new System.Drawing.Point(4, 22);
            this.tpCrawl1.Name = "tpCrawl1";
            this.tpCrawl1.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrawl1.Size = new System.Drawing.Size(580, 378);
            this.tpCrawl1.TabIndex = 0;
            this.tpCrawl1.Text = "Crawl1";
            this.tpCrawl1.UseVisualStyleBackColor = true;
            // 
            // btnCrawl1
            // 
            this.btnCrawl1.Location = new System.Drawing.Point(13, 14);
            this.btnCrawl1.Name = "btnCrawl1";
            this.btnCrawl1.Size = new System.Drawing.Size(75, 23);
            this.btnCrawl1.TabIndex = 7;
            this.btnCrawl1.Text = "Crawl";
            this.btnCrawl1.UseVisualStyleBackColor = true;
            this.btnCrawl1.Click += new System.EventHandler(this.btnCrawl1_Click);
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(535, 14);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(30, 23);
            this.btnChoose1.TabIndex = 6;
            this.btnChoose1.Text = "...";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // tbLocation1
            // 
            this.tbLocation1.Location = new System.Drawing.Point(95, 17);
            this.tbLocation1.Name = "tbLocation1";
            this.tbLocation1.Size = new System.Drawing.Size(434, 20);
            this.tbLocation1.TabIndex = 5;
            // 
            // dgData1
            // 
            this.dgData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData1.Location = new System.Drawing.Point(11, 47);
            this.dgData1.Name = "dgData1";
            this.dgData1.Size = new System.Drawing.Size(554, 322);
            this.dgData1.TabIndex = 4;
            // 
            // tpCrawl2
            // 
            this.tpCrawl2.Controls.Add(this.btnCrawl2);
            this.tpCrawl2.Controls.Add(this.btnChoose2);
            this.tpCrawl2.Controls.Add(this.dgData2);
            this.tpCrawl2.Controls.Add(this.tbLocation2);
            this.tpCrawl2.Location = new System.Drawing.Point(4, 22);
            this.tpCrawl2.Name = "tpCrawl2";
            this.tpCrawl2.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrawl2.Size = new System.Drawing.Size(580, 378);
            this.tpCrawl2.TabIndex = 1;
            this.tpCrawl2.Text = "Crawl2";
            this.tpCrawl2.UseVisualStyleBackColor = true;
            // 
            // btnCrawl2
            // 
            this.btnCrawl2.Location = new System.Drawing.Point(11, 18);
            this.btnCrawl2.Name = "btnCrawl2";
            this.btnCrawl2.Size = new System.Drawing.Size(75, 23);
            this.btnCrawl2.TabIndex = 8;
            this.btnCrawl2.Text = "Crawl";
            this.btnCrawl2.UseVisualStyleBackColor = true;
            this.btnCrawl2.Click += new System.EventHandler(this.btnCrawl2_Click);
            // 
            // btnChoose2
            // 
            this.btnChoose2.Location = new System.Drawing.Point(535, 18);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(30, 23);
            this.btnChoose2.TabIndex = 7;
            this.btnChoose2.Text = "...";
            this.btnChoose2.UseVisualStyleBackColor = true;
            this.btnChoose2.Click += new System.EventHandler(this.btnChoose2_Click);
            // 
            // dgData2
            // 
            this.dgData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData2.Location = new System.Drawing.Point(11, 49);
            this.dgData2.Name = "dgData2";
            this.dgData2.Size = new System.Drawing.Size(554, 311);
            this.dgData2.TabIndex = 3;
            // 
            // tbLocation2
            // 
            this.tbLocation2.Location = new System.Drawing.Point(92, 20);
            this.tbLocation2.Name = "tbLocation2";
            this.tbLocation2.Size = new System.Drawing.Size(437, 20);
            this.tbLocation2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 448);
            this.Controls.Add(this.tcCrawl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Web Crawler Demo";
            this.tcCrawl.ResumeLayout(false);
            this.tpCrawl1.ResumeLayout(false);
            this.tpCrawl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData1)).EndInit();
            this.tpCrawl2.ResumeLayout(false);
            this.tpCrawl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcCrawl;
        private System.Windows.Forms.TabPage tpCrawl1;
        private System.Windows.Forms.TextBox tbLocation1;
        private System.Windows.Forms.DataGridView dgData1;
        private System.Windows.Forms.TabPage tpCrawl2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbLocation2;
        private System.Windows.Forms.DataGridView dgData2;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.Button btnCrawl1;
        private System.Windows.Forms.Button btnCrawl2;
        private System.Windows.Forms.Button btnChoose2;
    }
}

