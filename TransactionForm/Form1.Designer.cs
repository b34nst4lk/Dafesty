namespace TransactionForm
{
    partial class TransactionForm
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
            this.LoanTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ReturnTab = new System.Windows.Forms.TabPage();
            this.LoanTransactionIDLabel = new System.Windows.Forms.Label();
            this.LoanCustomerIDLabel = new System.Windows.Forms.Label();
            this.LoanBorrowDateLabel = new System.Windows.Forms.Label();
            this.LoanDueDateLabel = new System.Windows.Forms.Label();
            this.LoanVideoCodeLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddVideo = new System.Windows.Forms.Button();
            this.TransactionID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.BorrowDate = new System.Windows.Forms.TextBox();
            this.VideoCode = new System.Windows.Forms.TextBox();
            this.DueDate = new System.Windows.Forms.TextBox();
            this.LoanOutput = new System.Windows.Forms.DataGridView();
            this.ClearForm = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnSearchCustomer = new System.Windows.Forms.Button();
            this.ReturnOutput = new System.Windows.Forms.DataGridView();
            this.ReturnVideos = new System.Windows.Forms.Button();
            this.ReturnClearForm = new System.Windows.Forms.Button();
            this.LoanTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ReturnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // LoanTab
            // 
            this.LoanTab.Controls.Add(this.tabPage1);
            this.LoanTab.Controls.Add(this.ReturnTab);
            this.LoanTab.Location = new System.Drawing.Point(24, 16);
            this.LoanTab.Name = "LoanTab";
            this.LoanTab.SelectedIndex = 0;
            this.LoanTab.Size = new System.Drawing.Size(472, 528);
            this.LoanTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Checkout);
            this.tabPage1.Controls.Add(this.ClearForm);
            this.tabPage1.Controls.Add(this.LoanOutput);
            this.tabPage1.Controls.Add(this.VideoCode);
            this.tabPage1.Controls.Add(this.DueDate);
            this.tabPage1.Controls.Add(this.BorrowDate);
            this.tabPage1.Controls.Add(this.CustomerID);
            this.tabPage1.Controls.Add(this.TransactionID);
            this.tabPage1.Controls.Add(this.AddVideo);
            this.tabPage1.Controls.Add(this.LoanVideoCodeLabel);
            this.tabPage1.Controls.Add(this.LoanDueDateLabel);
            this.tabPage1.Controls.Add(this.LoanBorrowDateLabel);
            this.tabPage1.Controls.Add(this.LoanCustomerIDLabel);
            this.tabPage1.Controls.Add(this.LoanTransactionIDLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReturnTab
            // 
            this.ReturnTab.Controls.Add(this.ReturnOutput);
            this.ReturnTab.Controls.Add(this.ReturnClearForm);
            this.ReturnTab.Controls.Add(this.ReturnVideos);
            this.ReturnTab.Controls.Add(this.ReturnSearchCustomer);
            this.ReturnTab.Controls.Add(this.textBox6);
            this.ReturnTab.Controls.Add(this.label1);
            this.ReturnTab.Location = new System.Drawing.Point(4, 22);
            this.ReturnTab.Name = "ReturnTab";
            this.ReturnTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReturnTab.Size = new System.Drawing.Size(464, 502);
            this.ReturnTab.TabIndex = 1;
            this.ReturnTab.Text = "Return";
            this.ReturnTab.UseVisualStyleBackColor = true;
            // 
            // LoanTransactionIDLabel
            // 
            this.LoanTransactionIDLabel.AutoSize = true;
            this.LoanTransactionIDLabel.Location = new System.Drawing.Point(16, 24);
            this.LoanTransactionIDLabel.Name = "LoanTransactionIDLabel";
            this.LoanTransactionIDLabel.Size = new System.Drawing.Size(80, 13);
            this.LoanTransactionIDLabel.TabIndex = 0;
            this.LoanTransactionIDLabel.Text = "Transaction ID:";
            // 
            // LoanCustomerIDLabel
            // 
            this.LoanCustomerIDLabel.AutoSize = true;
            this.LoanCustomerIDLabel.Location = new System.Drawing.Point(16, 48);
            this.LoanCustomerIDLabel.Name = "LoanCustomerIDLabel";
            this.LoanCustomerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.LoanCustomerIDLabel.TabIndex = 0;
            this.LoanCustomerIDLabel.Text = "Customer ID:";
            // 
            // LoanBorrowDateLabel
            // 
            this.LoanBorrowDateLabel.AutoSize = true;
            this.LoanBorrowDateLabel.Location = new System.Drawing.Point(16, 84);
            this.LoanBorrowDateLabel.Name = "LoanBorrowDateLabel";
            this.LoanBorrowDateLabel.Size = new System.Drawing.Size(69, 13);
            this.LoanBorrowDateLabel.TabIndex = 0;
            this.LoanBorrowDateLabel.Text = "Borrow Date:";
            // 
            // LoanDueDateLabel
            // 
            this.LoanDueDateLabel.AutoSize = true;
            this.LoanDueDateLabel.Location = new System.Drawing.Point(216, 84);
            this.LoanDueDateLabel.Name = "LoanDueDateLabel";
            this.LoanDueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.LoanDueDateLabel.TabIndex = 0;
            this.LoanDueDateLabel.Text = "Due Date:";
            // 
            // LoanVideoCodeLabel
            // 
            this.LoanVideoCodeLabel.AutoSize = true;
            this.LoanVideoCodeLabel.Location = new System.Drawing.Point(16, 116);
            this.LoanVideoCodeLabel.Name = "LoanVideoCodeLabel";
            this.LoanVideoCodeLabel.Size = new System.Drawing.Size(62, 13);
            this.LoanVideoCodeLabel.TabIndex = 0;
            this.LoanVideoCodeLabel.Text = "VideoCode:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AddVideo
            // 
            this.AddVideo.Location = new System.Drawing.Point(220, 112);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(109, 23);
            this.AddVideo.TabIndex = 2;
            this.AddVideo.Text = "Add Video";
            this.AddVideo.UseVisualStyleBackColor = true;
            // 
            // TransactionID
            // 
            this.TransactionID.Enabled = false;
            this.TransactionID.Location = new System.Drawing.Point(104, 20);
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Size = new System.Drawing.Size(96, 20);
            this.TransactionID.TabIndex = 3;
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(104, 44);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(96, 20);
            this.CustomerID.TabIndex = 3;
            // 
            // BorrowDate
            // 
            this.BorrowDate.Enabled = false;
            this.BorrowDate.Location = new System.Drawing.Point(104, 80);
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.Size = new System.Drawing.Size(96, 20);
            this.BorrowDate.TabIndex = 3;
            // 
            // VideoCode
            // 
            this.VideoCode.Location = new System.Drawing.Point(104, 112);
            this.VideoCode.Name = "VideoCode";
            this.VideoCode.Size = new System.Drawing.Size(96, 20);
            this.VideoCode.TabIndex = 3;
            // 
            // DueDate
            // 
            this.DueDate.Enabled = false;
            this.DueDate.Location = new System.Drawing.Point(288, 82);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(96, 20);
            this.DueDate.TabIndex = 3;
            // 
            // LoanOutput
            // 
            this.LoanOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.LoanOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanOutput.Location = new System.Drawing.Point(8, 152);
            this.LoanOutput.Name = "LoanOutput";
            this.LoanOutput.Size = new System.Drawing.Size(448, 256);
            this.LoanOutput.TabIndex = 4;
            // 
            // ClearForm
            // 
            this.ClearForm.Location = new System.Drawing.Point(32, 424);
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(75, 23);
            this.ClearForm.TabIndex = 5;
            this.ClearForm.Text = "Clear Form";
            this.ClearForm.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(336, 424);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(75, 23);
            this.Checkout.TabIndex = 5;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(104, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID:";
            // 
            // ReturnSearchCustomer
            // 
            this.ReturnSearchCustomer.Location = new System.Drawing.Point(16, 50);
            this.ReturnSearchCustomer.Name = "ReturnSearchCustomer";
            this.ReturnSearchCustomer.Size = new System.Drawing.Size(120, 23);
            this.ReturnSearchCustomer.TabIndex = 6;
            this.ReturnSearchCustomer.Text = "Search Customer";
            this.ReturnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // ReturnOutput
            // 
            this.ReturnOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnOutput.Location = new System.Drawing.Point(8, 88);
            this.ReturnOutput.Name = "ReturnOutput";
            this.ReturnOutput.Size = new System.Drawing.Size(448, 280);
            this.ReturnOutput.TabIndex = 7;
            // 
            // ReturnVideos
            // 
            this.ReturnVideos.Location = new System.Drawing.Point(320, 384);
            this.ReturnVideos.Name = "ReturnVideos";
            this.ReturnVideos.Size = new System.Drawing.Size(120, 23);
            this.ReturnVideos.TabIndex = 6;
            this.ReturnVideos.Text = "Return Videos";
            this.ReturnVideos.UseVisualStyleBackColor = true;
            // 
            // ReturnClearForm
            // 
            this.ReturnClearForm.Location = new System.Drawing.Point(24, 384);
            this.ReturnClearForm.Name = "ReturnClearForm";
            this.ReturnClearForm.Size = new System.Drawing.Size(120, 23);
            this.ReturnClearForm.TabIndex = 6;
            this.ReturnClearForm.Text = "Clear Form";
            this.ReturnClearForm.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 587);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LoanTab);
            this.Name = "TransactionForm";
            this.Text = "Transaction Form";
            this.LoanTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ReturnTab.ResumeLayout(false);
            this.ReturnTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl LoanTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox VideoCode;
        private System.Windows.Forms.TextBox DueDate;
        private System.Windows.Forms.TextBox BorrowDate;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.TextBox TransactionID;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.Label LoanVideoCodeLabel;
        private System.Windows.Forms.Label LoanDueDateLabel;
        private System.Windows.Forms.Label LoanBorrowDateLabel;
        private System.Windows.Forms.Label LoanCustomerIDLabel;
        private System.Windows.Forms.Label LoanTransactionIDLabel;
        private System.Windows.Forms.TabPage ReturnTab;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView LoanOutput;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Button ClearForm;
        private System.Windows.Forms.DataGridView ReturnOutput;
        private System.Windows.Forms.Button ReturnSearchCustomer;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnClearForm;
        private System.Windows.Forms.Button ReturnVideos;
    }
}

