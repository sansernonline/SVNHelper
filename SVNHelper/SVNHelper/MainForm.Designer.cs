namespace SVNHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txbBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnMoveRightToLeft = new System.Windows.Forms.Button();
            this.btnMoveLeftToRight = new System.Windows.Forms.Button();
            this.lsbRight = new System.Windows.Forms.ListBox();
            this.lsbLeft = new System.Windows.Forms.ListBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMoveRightToLeftAll = new System.Windows.Forms.Button();
            this.btnMoveLeftToRightAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBrowse
            // 
            this.txbBrowse.Location = new System.Drawing.Point(71, 19);
            this.txbBrowse.Name = "txbBrowse";
            this.txbBrowse.Size = new System.Drawing.Size(204, 20);
            this.txbBrowse.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(279, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoveRightToLeftAll);
            this.groupBox1.Controls.Add(this.btnMoveLeftToRightAll);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCheckout);
            this.groupBox1.Controls.Add(this.btnMoveRightToLeft);
            this.groupBox1.Controls.Add(this.btnMoveLeftToRight);
            this.groupBox1.Controls.Add(this.lsbRight);
            this.groupBox1.Controls.Add(this.lsbLeft);
            this.groupBox1.Location = new System.Drawing.Point(9, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(185, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(70, 199);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(98, 33);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "CHECKOUT !!";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnMoveRightToLeft
            // 
            this.btnMoveRightToLeft.Location = new System.Drawing.Point(151, 114);
            this.btnMoveRightToLeft.Name = "btnMoveRightToLeft";
            this.btnMoveRightToLeft.Size = new System.Drawing.Size(50, 23);
            this.btnMoveRightToLeft.TabIndex = 7;
            this.btnMoveRightToLeft.Text = "<";
            this.btnMoveRightToLeft.UseVisualStyleBackColor = true;
            this.btnMoveRightToLeft.Click += new System.EventHandler(this.btnMoveRightToLeft_Click);
            // 
            // btnMoveLeftToRight
            // 
            this.btnMoveLeftToRight.Location = new System.Drawing.Point(151, 46);
            this.btnMoveLeftToRight.Name = "btnMoveLeftToRight";
            this.btnMoveLeftToRight.Size = new System.Drawing.Size(50, 23);
            this.btnMoveLeftToRight.TabIndex = 6;
            this.btnMoveLeftToRight.Text = ">";
            this.btnMoveLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveLeftToRight.Click += new System.EventHandler(this.btnMoveLeftToRight_Click);
            // 
            // lsbRight
            // 
            this.lsbRight.FormattingEnabled = true;
            this.lsbRight.Location = new System.Drawing.Point(207, 15);
            this.lsbRight.Name = "lsbRight";
            this.lsbRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbRight.Size = new System.Drawing.Size(137, 173);
            this.lsbRight.TabIndex = 1;
            // 
            // lsbLeft
            // 
            this.lsbLeft.FormattingEnabled = true;
            this.lsbLeft.Location = new System.Drawing.Point(8, 15);
            this.lsbLeft.Name = "lsbLeft";
            this.lsbLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbLeft.Size = new System.Drawing.Size(137, 173);
            this.lsbLeft.TabIndex = 0;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(72, 15);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(95, 20);
            this.txbUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(10, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password :";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(242, 15);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(95, 20);
            this.txbPass.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbUser);
            this.groupBox2.Controls.Add(this.txbPass);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 45);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 340);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 16);
            this.progressBar1.TabIndex = 11;
            // 
            // btnMoveRightToLeftAll
            // 
            this.btnMoveRightToLeftAll.Location = new System.Drawing.Point(151, 140);
            this.btnMoveRightToLeftAll.Name = "btnMoveRightToLeftAll";
            this.btnMoveRightToLeftAll.Size = new System.Drawing.Size(50, 23);
            this.btnMoveRightToLeftAll.TabIndex = 14;
            this.btnMoveRightToLeftAll.Text = "<<";
            this.btnMoveRightToLeftAll.UseVisualStyleBackColor = true;
            this.btnMoveRightToLeftAll.Click += new System.EventHandler(this.btnMoveRightToLeftAll_Click);
            // 
            // btnMoveLeftToRightAll
            // 
            this.btnMoveLeftToRightAll.Location = new System.Drawing.Point(151, 72);
            this.btnMoveLeftToRightAll.Name = "btnMoveLeftToRightAll";
            this.btnMoveLeftToRightAll.Size = new System.Drawing.Size(50, 23);
            this.btnMoveLeftToRightAll.TabIndex = 13;
            this.btnMoveLeftToRightAll.Text = ">>";
            this.btnMoveLeftToRightAll.UseVisualStyleBackColor = true;
            this.btnMoveLeftToRightAll.Click += new System.EventHandler(this.btnMoveLeftToRightAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 365);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txbBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SVNHelper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbRight;
        private System.Windows.Forms.ListBox lsbLeft;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveRightToLeft;
        private System.Windows.Forms.Button btnMoveLeftToRight;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheckout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnMoveRightToLeftAll;
        private System.Windows.Forms.Button btnMoveLeftToRightAll;
    }
}

