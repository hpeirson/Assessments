using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HWP.WebCrawler.Middleware;

namespace WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private async void btnCrawl1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLocation1.Text))
            {
                List<ResultModel> rows = null;
                await Task.Run(() =>
                {
                    rows = doCrawl(tbLocation1.Text);
                });
                var source = new BindingSource();
                dgData1.AutoGenerateColumns = true;
                dgData1.DataSource = rows;
                dgData1.Refresh();
            }
            else {
                MessageBox.Show("Please select a valid file...");
            }
        }

        private async void btnCrawl2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLocation2.Text))
            {
                List<ResultModel> rows = null;
                await Task.Run(() =>
                {
                    rows = doCrawl(tbLocation2.Text);
                });
                var source = new BindingSource();
                dgData2.AutoGenerateColumns = true;
                dgData2.DataSource = rows;
                dgData2.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a valid file...");
            }
            
        }

        private List<ResultModel> doCrawl(string loc)
        {
            var obj = CrawlHelper.JsonToObject<PagesResponse>(loc);
            var rows = Crawler.ProcessCrawl(loc);

            return rows;
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            tbLocation1.Text = ChooseLocation();
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            tbLocation2.Text = ChooseLocation();
        }

        private string ChooseLocation()
        {
            string retval = string.Empty;
            Stream strm = null;
            string startdir = Path.Combine(Environment.CurrentDirectory, "Data"); ;
            string filter = "json files (*.json)|*.json"; ;
            string title = "Select File...";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;
            dialog.RestoreDirectory = true;
            dialog.Title = title;
            dialog.InitialDirectory = startdir;

            if (dialog.ShowDialog().ToString().Equals("OK"))
            {
                try
                {
                    if ((strm = dialog.OpenFile()) != null)
                    {
                        using (strm)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                    retval = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            return retval;
        }

        #region Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        
    }
}
