
using ClassLibrary.DAO;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinApp
{
    public partial class frmStudentInterface : Form
    {
        public frmStudentInterface()
        {
            InitializeComponent();
        }
        public Account LoginInfor { get; set; }
        BindingSource source;
        

        private void frmStudentInterface_Load(object sender, EventArgs e)
        {
            rbtnViewBook.Checked = true;
            var BookList = BookDAO.Instance.GetBookList();
            source = new BindingSource();
            source.DataSource = BookList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;
        }

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtBookID.Text = row.Cells[0].Value.ToString();
                

            }

        }

        private void rbtnViewBook_CheckedChanged(object sender, EventArgs e)
        {
            var BookList = BookDAO.Instance.GetBookList();
            source = new BindingSource();
            source.DataSource = BookList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;

            txtBookID.Visible = true;
            btnOrder.Visible = true;
            rbtnBorrowing.Visible = false;
            rbtnOverdue.Visible = false;
            rbtnAll.Visible = false;
            rbtnOrdering.Visible = false;
        }

        private void rbtnViewHistory_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetBorrowingListByStuID(2);
            source = new BindingSource();
            source.DataSource = historyList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;

            txtBookID.Visible= false;
            btnOrder.Visible = false;
            rbtnBorrowing.Visible = true;
            rbtnOverdue.Visible = true;
            rbtnAll.Visible = true;
            rbtnOrdering.Visible = true;
        }

        private void rbtnBorrowing_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetBorrowingList().Where(p=>p.StudentId==2 );
            source = new BindingSource();
            source.DataSource = historyList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;
        }

        private void rbtnOverdue_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetOverdueList().Where(p => p.StudentId == 2);
            source = new BindingSource();
            source.DataSource = historyList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetHistoryList().Where(p => p.StudentId == 2);
            source = new BindingSource();
            source.DataSource = historyList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var newHis = new History()
                {
                    //LibrarianId = LoginInfor.AccountId,
                    LibrarianId= 0,
                    StudentId = 2,
                    BookId = int.Parse(txtBookID.Text),
                    BorrowDate= DateTime.Now,
                };

                HistoryDAO.Instance.InsertHistory(newHis);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            rbtnViewBook.Checked = true;
            var BookList = BookDAO.Instance.GetBookList();
            source = new BindingSource();
            source.DataSource = BookList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;
        }

        private void rbtnOrdering_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetHistoryList().Where(p => p.StudentId == 2).Where(p => p.LibrarianId == 0);
            source = new BindingSource();
            source.DataSource = historyList;
            dgvData.DataSource = null;
            dgvData.DataSource = source;
        }

        private void btnLogout_Click(object sender, EventArgs e) => Close();
    }
}
