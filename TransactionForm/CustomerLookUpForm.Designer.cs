namespace TransactionForm
{
    partial class CustomerLookupForm
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
            this.ClearSearch = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.LookupOutput = new System.Windows.Forms.DataGridView();
            this.LookUpCustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.LookUpCustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LookupCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LookupCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LookupOutput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearSearch
            // 
            this.ClearSearch.Location = new System.Drawing.Point(96, 312);
            this.ClearSearch.Name = "ClearSearch";
            this.ClearSearch.Size = new System.Drawing.Size(75, 23);
            this.ClearSearch.TabIndex = 0;
            this.ClearSearch.Text = "Clear Form";
            this.ClearSearch.UseVisualStyleBackColor = true;
            this.ClearSearch.Click += new System.EventHandler(this.ClearSearch_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(288, 312);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // LookupOutput
            // 
            this.LookupOutput.AllowUserToAddRows = false;
            this.LookupOutput.AllowUserToDeleteRows = false;
            this.LookupOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LookupOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LookupCustomerID,
            this.LookupCustomerName,
            this.Address,
            this.PhoneNum});
            this.LookupOutput.Location = new System.Drawing.Point(16, 96);
            this.LookupOutput.MultiSelect = false;
            this.LookupOutput.Name = "LookupOutput";
            this.LookupOutput.ReadOnly = true;
            this.LookupOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LookupOutput.Size = new System.Drawing.Size(448, 200);
            this.LookupOutput.TabIndex = 1;
            // 
            // LookUpCustomerIDLabel
            // 
            this.LookUpCustomerIDLabel.AutoSize = true;
            this.LookUpCustomerIDLabel.Location = new System.Drawing.Point(112, 40);
            this.LookUpCustomerIDLabel.Name = "LookUpCustomerIDLabel";
            this.LookUpCustomerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.LookUpCustomerIDLabel.TabIndex = 2;
            this.LookUpCustomerIDLabel.Text = "Customer ID:";
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(200, 36);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(100, 20);
            this.CustomerID.TabIndex = 3;
            this.CustomerID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LookUp_KeyUp);
            // 
            // LookUpCustomerNameLabel
            // 
            this.LookUpCustomerNameLabel.AutoSize = true;
            this.LookUpCustomerNameLabel.Location = new System.Drawing.Point(111, 64);
            this.LookUpCustomerNameLabel.Name = "LookUpCustomerNameLabel";
            this.LookUpCustomerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.LookUpCustomerNameLabel.TabIndex = 2;
            this.LookUpCustomerNameLabel.Text = "Customer Name:";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(199, 60);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 3;
            this.CustomerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LookUp_KeyUp);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(192, 312);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(475, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // LookupCustomerID
            // 
            this.LookupCustomerID.DataPropertyName = "CustomerID";
            this.LookupCustomerID.HeaderText = "Customer ID";
            this.LookupCustomerID.Name = "LookupCustomerID";
            this.LookupCustomerID.ReadOnly = true;
            // 
            // LookupCustomerName
            // 
            this.LookupCustomerName.DataPropertyName = "CustomerName";
            this.LookupCustomerName.HeaderText = "Customer Name";
            this.LookupCustomerName.Name = "LookupCustomerName";
            this.LookupCustomerName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNumber";
            this.PhoneNum.HeaderText = "Phone No.";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // CustomerLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.LookUpCustomerNameLabel);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.LookUpCustomerIDLabel);
            this.Controls.Add(this.LookupOutput);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.ClearSearch);
            this.Name = "CustomerLookupForm";
            this.Text = "Customer Lookup Form";
            ((System.ComponentModel.ISupportInitialize)(this.LookupOutput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearSearch;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView LookupOutput;
        private System.Windows.Forms.Label LookUpCustomerIDLabel;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label LookUpCustomerNameLabel;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookupCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookupCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
    }
}