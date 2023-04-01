
using Azure.Core.GeoJson;
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
using System.Xml.Linq;

namespace LibraryWinApp
{
    public partial class frmLibraryManagement : Form
    {
        public frmLibraryManagement()
        {
            InitializeComponent();
        }

        BindingSource source;

        public Account LoginInfor { get; set; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void LoadAllHistoryList()
        {
            var historyList = HistoryDAO.Instance.GetHistoryList();
            source = new BindingSource();
            source.DataSource = historyList;
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = source;
        }
        private void frmLibraryManagement_Load(object sender, EventArgs e)
        {
            cboSort.SelectedIndex = 0;
            LoadAllHistoryList();
        }

        private void rbtnChuaTra_Click(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetBorrowingList();
            source = new BindingSource();
            source.DataSource = historyList;
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = source;
        }

        private void rbtnDatra_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetReturnedList();
            source = new BindingSource();
            source.DataSource = historyList;
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = source;
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllHistoryList();
        }

        private void rbtnQuahan_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetOverdueList();
            source = new BindingSource();
            source.DataSource = historyList;
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = source;
        }

        private void btnLogout_Click(object sender, EventArgs e) => Close();

        private void dgvHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistory.Rows[e.RowIndex];
                txtHistoryID.Text = row.Cells[0].Value.ToString();
                txtLibraryAccountID.Text = row.Cells[1].Value.ToString();
                txtStudentAccountID.Text = row.Cells[2].Value.ToString();
                txtBookID.Text = row.Cells[3].Value.ToString();
                txtBorrowDate.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value != null)
                {
                    txtReturnDeadline.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    txtReturnDeadline.Text = String.Empty;
                }
                
                if (row.Cells[6].Value != null)
                {
                    txtReturnedDate.Text = row.Cells[6].Value.ToString();
                }
                else
                {
                    txtReturnedDate.Text = String.Empty;
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var historyList = HistoryDAO.Instance.GetBorrowingListByStuID(Int32.Parse(txtSearch.Text));
                source = new BindingSource();
                source.DataSource = historyList;
                dgvHistory.DataSource = null;
                dgvHistory.DataSource = source;
            }
            catch (Exception)
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newHis = new History()
                {
                    //LibrarianId = LoginInfor.AccountId,
                    LibrarianId = 1,
                    StudentId = int.Parse(txtStudentAccountID.Text),
                    BookId = int.Parse(txtBookID.Text),
                    BorrowDate = DateTime.Now,
                    ReturnDeadline = (DateTime.Now).AddDays(7),
                    ReturnedDate = null
                };

                HistoryDAO.Instance.InsertHistory(newHis);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            LoadAllHistoryList();
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            try
            {
                var newHis = new History()
                {
                    HistoryId = int.Parse(txtHistoryID.Text),
                    LibrarianId = 1,
                    StudentId = int.Parse(txtStudentAccountID.Text),
                    BookId = int.Parse(txtBookID.Text),
                    BorrowDate = DateTime.Parse(txtBorrowDate.Text),
                    ReturnDeadline = DateTime.Parse(txtReturnDeadline.Text),
                    ReturnedDate = DateTime.Now
                };
                HistoryDAO.Instance.UpdateHistory(newHis);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            LoadAllHistoryList();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            frmBookManagement BookManagement = new frmBookManagement
            {
                LoginInfor = LoginInfor
            };
            BookManagement.ShowDialog();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSort.SelectedIndex ==1)
            {
                var historyList = HistoryDAO.Instance.GetHistoryAscending();
                source = new BindingSource();
                source.DataSource = historyList;
                dgvHistory.DataSource = null;
                dgvHistory.DataSource = source;
            }else if (cboSort.SelectedIndex == 2)
            {
                var historyList = HistoryDAO.Instance.GetHistoryDescending();
                source = new BindingSource();
                source.DataSource = historyList;
                dgvHistory.DataSource = null;
                dgvHistory.DataSource = source;
            }
            else
            {
                LoadAllHistoryList();
            }
        }

        private void rbtnOrdering_CheckedChanged(object sender, EventArgs e)
        {
            var historyList = HistoryDAO.Instance.GetOrderingList();
            source = new BindingSource();
            source.DataSource = historyList;
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = source;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var His = new History()
                {
                    HistoryId = int.Parse(txtHistoryID.Text),
                    LibrarianId = 1,
                    StudentId = int.Parse(txtStudentAccountID.Text),
                    BookId = int.Parse(txtBookID.Text),
                    BorrowDate = DateTime.Now,
                    ReturnDeadline = (DateTime.Now).AddDays(7),
                    ReturnedDate = null
                };
                HistoryDAO.Instance.UpdateHistory(His);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            rbtnOrdering.Enabled = false;
            LoadAllHistoryList();
        }
        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    txtID.Text = string.Empty;
        //    txtName.Text = string.Empty;
        //    rbtnFemale.Checked = false;
        //    rbtnMale.Checked = false;
        //    cboPosition.SelectedIndex = 0;
        //    DOB.Value = DateTime.Now;

        //}
    }
}
