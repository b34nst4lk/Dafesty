namespace TransactionForm
{
    partial class MovieLookupForm
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
            this.VideoCodeLabel = new System.Windows.Forms.Label();
            this.VideoCode = new System.Windows.Forms.TextBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LookupVideoCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LookupMovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.LookupVideoCode,
            this.LookupMovieTitle});
            this.LookupOutput.Location = new System.Drawing.Point(16, 96);
            this.LookupOutput.MultiSelect = false;
            this.LookupOutput.Name = "LookupOutput";
            this.LookupOutput.ReadOnly = true;
            this.LookupOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LookupOutput.Size = new System.Drawing.Size(448, 200);
            this.LookupOutput.TabIndex = 1;
            // 
            // VideoCodeLabel
            // 
            this.VideoCodeLabel.AutoSize = true;
            this.VideoCodeLabel.Location = new System.Drawing.Point(112, 40);
            this.VideoCodeLabel.Name = "VideoCodeLabel";
            this.VideoCodeLabel.Size = new System.Drawing.Size(65, 13);
            this.VideoCodeLabel.TabIndex = 2;
            this.VideoCodeLabel.Text = "Video Code:";
            // 
            // VideoCode
            // 
            this.VideoCode.Location = new System.Drawing.Point(200, 36);
            this.VideoCode.Name = "VideoCode";
            this.VideoCode.Size = new System.Drawing.Size(100, 20);
            this.VideoCode.TabIndex = 3;
            this.VideoCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LookUp_KeyUp);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(111, 64);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "Movie Title:";
            // 
            // MovieTitle
            // 
            this.MovieTitle.Location = new System.Drawing.Point(199, 60);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(100, 20);
            this.MovieTitle.TabIndex = 3;
            this.MovieTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LookUp_KeyUp);
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
            // LookupVideoCode
            // 
            this.LookupVideoCode.DataPropertyName = "VideoCode";
            this.LookupVideoCode.HeaderText = "Video Code";
            this.LookupVideoCode.Name = "LookupVideoCode";
            this.LookupVideoCode.ReadOnly = true;
            // 
            // LookupMovieTitle
            // 
            this.LookupMovieTitle.DataPropertyName = "MovieTitle";
            this.LookupMovieTitle.HeaderText = "Movie Title";
            this.LookupMovieTitle.Name = "LookupMovieTitle";
            this.LookupMovieTitle.ReadOnly = true;
            // 
            // MovieLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.VideoCode);
            this.Controls.Add(this.VideoCodeLabel);
            this.Controls.Add(this.LookupOutput);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.ClearSearch);
            this.Name = "MovieLookupForm";
            this.Text = "Movies Lookup Form";
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
        private System.Windows.Forms.Label VideoCodeLabel;
        private System.Windows.Forms.TextBox VideoCode;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.TextBox MovieTitle;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookupVideoCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookupMovieTitle;
    }
}