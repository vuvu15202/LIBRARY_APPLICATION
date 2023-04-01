namespace LibraryWinApp
{
    partial class frmLibraryManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HistoryID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturned = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtReturnedDate = new System.Windows.Forms.TextBox();
            this.txtReturnDeadline = new System.Windows.Forms.TextBox();
            this.txtBorrowDate = new System.Windows.Forms.TextBox();
            this.txtStudentAccountID = new System.Windows.Forms.TextBox();
            this.txtLibraryAccountID = new System.Windows.Forms.TextBox();
            this.txtHistoryID = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.rbtnChuaTra = new System.Windows.Forms.RadioButton();
            this.rbtnQuahan = new System.Windows.Forms.RadioButton();
            this.rbtnDatra = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.rbtnOrdering = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RetunredDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ReturnDeadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "BorrowDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "StudentID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "LibrarianID";
            // 
            // HistoryID
            // 
            this.HistoryID.AutoSize = true;
            this.HistoryID.Location = new System.Drawing.Point(36, 41);
            this.HistoryID.Name = "HistoryID";
            this.HistoryID.Size = new System.Drawing.Size(71, 20);
            this.HistoryID.TabIndex = 6;
            this.HistoryID.Text = "HistoryID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(339, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "Library Management";
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(33, 161);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 29;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(859, 322);
            this.dgvHistory.TabIndex = 8;
            this.dgvHistory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHistory_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReturned);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtReturnedDate);
            this.groupBox1.Controls.Add(this.txtReturnDeadline);
            this.groupBox1.Controls.Add(this.txtBorrowDate);
            this.groupBox1.Controls.Add(this.txtStudentAccountID);
            this.groupBox1.Controls.Add(this.txtLibraryAccountID);
            this.groupBox1.Controls.Add(this.txtHistoryID);
            this.groupBox1.Controls.Add(this.HistoryID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(924, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 453);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current History";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(175, 181);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(152, 27);
            this.txtBookID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "BookID";
            // 
            // btnReturned
            // 
            this.btnReturned.Location = new System.Drawing.Point(233, 389);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(94, 29);
            this.btnReturned.TabIndex = 16;
            this.btnReturned.Text = "Returned";
            this.btnReturned.UseVisualStyleBackColor = true;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 29);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtReturnedDate
            // 
            this.txtReturnedDate.Location = new System.Drawing.Point(175, 336);
            this.txtReturnedDate.Name = "txtReturnedDate";
            this.txtReturnedDate.ReadOnly = true;
            this.txtReturnedDate.Size = new System.Drawing.Size(152, 27);
            this.txtReturnedDate.TabIndex = 21;
            // 
            // txtReturnDeadline
            // 
            this.txtReturnDeadline.Location = new System.Drawing.Point(175, 285);
            this.txtReturnDeadline.Name = "txtReturnDeadline";
            this.txtReturnDeadline.ReadOnly = true;
            this.txtReturnDeadline.Size = new System.Drawing.Size(152, 27);
            this.txtReturnDeadline.TabIndex = 20;
            // 
            // txtBorrowDate
            // 
            this.txtBorrowDate.Location = new System.Drawing.Point(175, 233);
            this.txtBorrowDate.Name = "txtBorrowDate";
            this.txtBorrowDate.ReadOnly = true;
            this.txtBorrowDate.Size = new System.Drawing.Size(152, 27);
            this.txtBorrowDate.TabIndex = 16;
            // 
            // txtStudentAccountID
            // 
            this.txtStudentAccountID.Location = new System.Drawing.Point(175, 132);
            this.txtStudentAccountID.Name = "txtStudentAccountID";
            this.txtStudentAccountID.Size = new System.Drawing.Size(152, 27);
            this.txtStudentAccountID.TabIndex = 17;
            // 
            // txtLibraryAccountID
            // 
            this.txtLibraryAccountID.Location = new System.Drawing.Point(175, 81);
            this.txtLibraryAccountID.Name = "txtLibraryAccountID";
            this.txtLibraryAccountID.Size = new System.Drawing.Size(152, 27);
            this.txtLibraryAccountID.TabIndex = 18;
            // 
            // txtHistoryID
            // 
            this.txtHistoryID.Location = new System.Drawing.Point(175, 34);
            this.txtHistoryID.Name = "txtHistoryID";
            this.txtHistoryID.ReadOnly = true;
            this.txtHistoryID.Size = new System.Drawing.Size(152, 27);
            this.txtHistoryID.TabIndex = 19;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(630, 579);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 37);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // rbtnChuaTra
            // 
            this.rbtnChuaTra.AutoSize = true;
            this.rbtnChuaTra.Location = new System.Drawing.Point(154, 501);
            this.rbtnChuaTra.Name = "rbtnChuaTra";
            this.rbtnChuaTra.Size = new System.Drawing.Size(99, 24);
            this.rbtnChuaTra.TabIndex = 10;
            this.rbtnChuaTra.TabStop = true;
            this.rbtnChuaTra.Text = "Borrowing";
            this.rbtnChuaTra.UseVisualStyleBackColor = true;
            this.rbtnChuaTra.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rbtnChuaTra.Click += new System.EventHandler(this.rbtnChuaTra_Click);
            // 
            // rbtnQuahan
            // 
            this.rbtnQuahan.AutoSize = true;
            this.rbtnQuahan.Location = new System.Drawing.Point(273, 501);
            this.rbtnQuahan.Name = "rbtnQuahan";
            this.rbtnQuahan.Size = new System.Drawing.Size(86, 24);
            this.rbtnQuahan.TabIndex = 11;
            this.rbtnQuahan.TabStop = true;
            this.rbtnQuahan.Text = "Overdue";
            this.rbtnQuahan.UseVisualStyleBackColor = true;
            this.rbtnQuahan.CheckedChanged += new System.EventHandler(this.rbtnQuahan_CheckedChanged);
            // 
            // rbtnDatra
            // 
            this.rbtnDatra.AutoSize = true;
            this.rbtnDatra.Location = new System.Drawing.Point(384, 501);
            this.rbtnDatra.Name = "rbtnDatra";
            this.rbtnDatra.Size = new System.Drawing.Size(90, 24);
            this.rbtnDatra.TabIndex = 12;
            this.rbtnDatra.TabStop = true;
            this.rbtnDatra.Text = "Returned";
            this.rbtnDatra.UseVisualStyleBackColor = true;
            this.rbtnDatra.CheckedChanged += new System.EventHandler(this.rbtnDatra_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(501, 501);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(48, 24);
            this.rbtnAll.TabIndex = 13;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by StudentID";
            this.txtSearch.Size = new System.Drawing.Size(221, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Sort by Borrow Date",
            "Ascending",
            "Descending"});
            this.cboSort.Location = new System.Drawing.Point(348, 111);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(269, 28);
            this.cboSort.TabIndex = 14;
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.Location = new System.Drawing.Point(735, 501);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Size = new System.Drawing.Size(157, 40);
            this.btnBookManagement.TabIndex = 15;
            this.btnBookManagement.Text = "Book Management";
            this.btnBookManagement.UseVisualStyleBackColor = true;
            this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click);
            // 
            // rbtnOrdering
            // 
            this.rbtnOrdering.AutoSize = true;
            this.rbtnOrdering.Location = new System.Drawing.Point(44, 501);
            this.rbtnOrdering.Name = "rbtnOrdering";
            this.rbtnOrdering.Size = new System.Drawing.Size(89, 24);
            this.rbtnOrdering.TabIndex = 16;
            this.rbtnOrdering.TabStop = true;
            this.rbtnOrdering.Text = "Ordering";
            this.rbtnOrdering.UseVisualStyleBackColor = true;
            this.rbtnOrdering.CheckedChanged += new System.EventHandler(this.rbtnOrdering_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 389);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmLibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 653);
            this.Controls.Add(this.rbtnOrdering);
            this.Controls.Add(this.btnBookManagement);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.rbtnDatra);
            this.Controls.Add(this.rbtnQuahan);
            this.Controls.Add(this.rbtnChuaTra);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.label8);
            this.Name = "frmLibraryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLibraryManagement";
            this.Load += new System.EventHandler(this.frmLibraryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label HistoryID;
        private Label label8;
        private DataGridView dgvHistory;
        private GroupBox groupBox1;
        private Button btnLogout;
        private RadioButton rbtnChuaTra;
        private RadioButton rbtnQuahan;
        private RadioButton rbtnDatra;
        private RadioButton rbtnAll;
        private TextBox txtSearch;
        private Button btnReturned;
        private Button btnAdd;
        private TextBox txtReturnedDate;
        private TextBox txtReturnDeadline;
        private TextBox txtBorrowDate;
        private TextBox txtStudentAccountID;
        private TextBox txtLibraryAccountID;
        private TextBox txtHistoryID;
        private TextBox txtBookID;
        private Label label1;
        private ComboBox cboSort;
        private Button btnBookManagement;
        private RadioButton rbtnOrdering;
        private Button btnUpdate;
    }
}