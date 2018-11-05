using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using SVNProjectList.Classes;

namespace SVNHelper
{
    public partial class MainForm : Form
    {
        Helper.Classes.Helper HP = new Helper.Classes.Helper();

        public MainForm()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            ListBoxHelper.setListBoxItems(lsbLeft, ListBoxHelper.getAllItems());
        }


        private void btnMoveLeftToRight_Click(object sender, EventArgs e)
        {
            ListBoxHelper.moveItemsLeftToRight(lsbLeft, lsbRight);
        }

        private void btnMoveRightToLeft_Click(object sender, EventArgs e)
        {
            ListBoxHelper.moveItemsRightToleft(lsbLeft, lsbRight);
        }

        private void btnMoveLeftToRightAll_Click(object sender, EventArgs e)
        {
            ListBoxHelper.moveItemsLeftToRightAll(lsbLeft, lsbRight);
        }

        private void btnMoveRightToLeftAll_Click(object sender, EventArgs e)
        {
            ListBoxHelper.moveItemsRightToleftAll(lsbLeft, lsbRight);
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                progressBar1.Value = 0;
                btnCheckout.Enabled = false;
                HP.svnAuthen(txbUser.Text, txbPass.Text);
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (txbBrowse.Text != "" && txbUser.Text != "" && txbPass.Text != "")
            {
                List<string> items = ListBoxHelper.getAllItems(lsbRight);

                for (int i = 0; i < items.Count; i++)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        HP.doCheckOut(items.ElementAt(i), txbBrowse.Text);
                        worker.ReportProgress(((i+1) * 100) / items.Count);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { 
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            btnCheckout.Enabled = true;

            //if (e.Cancelled == true)
            //{
            //    rtbLoging.Text = "Canceled !";
            //}
            //else if (e.Error != null)
            //{
            //    rtbLoging.Text = "Error: " + e.Error.Message;
            //}
            //else
            //{
            //    rtbLoging.Text = "Done !";
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txbBrowse.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txbBrowse.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                btnCheckout.Enabled = true;
                backgroundWorker1.CancelAsync();
            }
        }

        
    }
}
