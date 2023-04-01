namespace LibraryWinApp
{
    partial class frmStudentInterface
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
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnBorrowing = new System.Windows.Forms.RadioButton();
            this.rbtnOverdue = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.rbtnViewHistory = new System.Windows.Forms.RadioButton();
            this.rbtnViewBook = new System.Windows.Forms.RadioButton();
            this.rbtnOrdering = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(87, 535);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PlaceholderText = "Choose BookID";
            this.txtBookID.Size = new System.Drawing.Size(228, 27);
            this.txtBookID.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(69, 137);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(888, 364);
            this.dgvData.TabIndex = 6;
            this.dgvData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(485, 622);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(425, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome";
            // 
            // rbtnBorrowing
            // 
            this.rbtnBorrowing.AutoSize = true;
            this.rbtnBorrowing.Location = new System.Drawing.Point(681, 535);
            this.rbtnBorrowing.Name = "rbtnBorrowing";
            this.rbtnBorrowing.Size = new System.Drawing.Size(99, 24);
            this.rbtnBorrowing.TabIndex = 11;
            this.rbtnBorrowing.TabStop = true;
            this.rbtnBorrowing.Text = "Borrowing";
            this.rbtnBorrowing.UseVisualStyleBackColor = true;
            this.rbtnBorrowing.Visible = false;
            this.rbtnBorrowing.CheckedChanged += new System.EventHandler(this.rbtnBorrowing_CheckedChanged);
            // 
            // rbtnOverdue
            // 
            this.rbtnOverdue.AutoSize = true;
            this.rbtnOverdue.Location = new System.Drawing.Point(798, 535);
            this.rbtnOverdue.Name = "rbtnOverdue";
            this.rbtnOverdue.Size = new System.Drawing.Size(86, 24);
            this.rbtnOverdue.TabIndex = 12;
            this.rbtnOverdue.TabStop = true;
            this.rbtnOverdue.Text = "Overdue";
            this.rbtnOverdue.UseVisualStyleBackColor = true;
            this.rbtnOverdue.Visible = false;
            this.rbtnOverdue.CheckedChanged += new System.EventHandler(this.rbtnOverdue_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(909, 535);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(48, 24);
            this.rbtnAll.TabIndex = 13;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.Visible = false;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(366, 535);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 29);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // rbtnViewHistory
            // 
            this.rbtnViewHistory.AutoSize = true;
            this.rbtnViewHistory.Location = new System.Drawing.Point(224, 97);
            this.rbtnViewHistory.Name = "rbtnViewHistory";
            this.rbtnViewHistory.Size = new System.Drawing.Size(113, 24);
            this.rbtnViewHistory.TabIndex = 15;
            this.rbtnViewHistory.TabStop = true;
            this.rbtnViewHistory.Text = "View History";
            this.rbtnViewHistory.UseVisualStyleBackColor = true;
            this.rbtnViewHistory.CheckedChanged += new System.EventHandler(this.rbtnViewHistory_CheckedChanged);
            // 
            // rbtnViewBook
            // 
            this.rbtnViewBook.AutoSize = true;
            this.rbtnViewBook.Location = new System.Drawing.Point(69, 97);
            this.rbtnViewBook.Name = "rbtnViewBook";
            this.rbtnViewBook.Size = new System.Drawing.Size(100, 24);
            this.rbtnViewBook.TabIndex = 16;
            this.rbtnViewBook.TabStop = true;
            this.rbtnViewBook.Text = "View Book";
            this.rbtnViewBook.UseVisualStyleBackColor = true;
            this.rbtnViewBook.CheckedChanged += new System.EventHandler(this.rbtnViewBook_CheckedChanged);
            // 
            // rbtnOrdering
            // 
            this.rbtnOrdering.AutoSize = true;
            this.rbtnOrdering.Location = new System.Drawing.Point(565, 535);
            this.rbtnOrdering.Name = "rbtnOrdering";
            this.rbtnOrdering.Size = new System.Drawing.Size(89, 24);
            this.rbtnOrdering.TabIndex = 17;
            this.rbtnOrdering.TabStop = true;
            this.rbtnOrdering.Text = "Ordering";
            this.rbtnOrdering.UseVisualStyleBackColor = true;
            this.rbtnOrdering.CheckedChanged += new System.EventHandler(this.rbtnOrdering_CheckedChanged);
            // 
            // frmStudentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 685);
            this.Controls.Add(this.rbtnOrdering);
            this.Controls.Add(this.rbtnViewBook);
            this.Controls.Add(this.rbtnViewHistory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.rbtnOverdue);
            this.Controls.Add(this.rbtnBorrowing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtBookID);
            this.Name = "frmStudentInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Interface";
            this.Load += new System.EventHandler(this.frmStudentInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBookID;
        private DataGridView dgvData;
        private Button btnLogout;
        private Label label1;
        private RadioButton rbtnBorrowing;
        private RadioButton rbtnOverdue;
        private RadioButton rbtnAll;
        private Button btnOrder;
        private RadioButton rbtnViewHistory;
        private RadioButton rbtnViewBook;
        private RadioButton rbtnOrdering;
    }
}