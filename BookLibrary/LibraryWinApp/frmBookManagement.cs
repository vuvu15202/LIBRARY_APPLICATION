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
using System.IO;

namespace LibraryWinApp
{
    public partial class frmBookManagement : Form
    {
        public frmBookManagement()
        {
            InitializeComponent();
        }
        public Account LoginInfor { get; set; }
        private void btnManageBook_Click(object sender, EventArgs e)
        {

        }

        BindingSource source;
        public void LoadAllBookList()
        {
            var historyList = BookDAO.Instance.GetBookList();
            source = new BindingSource();
            source.DataSource = historyList;
            dgvBook.DataSource = null;
            dgvBook.DataSource = source;
            if (txtImage.Text.Length == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\BookLibrary\\LibraryWinApp\\BookImages\\UnknownImage.jpg");

            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\BookLibrary\\LibraryWinApp\\BookImages\\"+txtImage.Text);
            }
        }

        private void frmBookManagement_Load(object sender, EventArgs e)
        {
            cboCategory.SelectedIndex= 0;
            LoadAllBookList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var historyList = BookDAO.Instance.GetBookListByName(txtSearch.Text);
                source = new BindingSource();
                source.DataSource = historyList;
                dgvBook.DataSource = null;
                dgvBook.DataSource = source;
            }
            catch (Exception)
            {

            }
        }

        private void dgvBook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBook.Rows[e.RowIndex];
                txtBookID.Text = row.Cells[0].Value.ToString();
                txtBookName.Text = row.Cells[1].Value.ToString();
                txtCategory.Text = row.Cells[2].Value.ToString();
                
                if (row.Cells[3].Value != null)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\BookLibrary\\LibraryWinApp\\BookImages\\"+row.Cells[3].Value.ToString());
                    txtImage.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    txtImage.Text = String.Empty;
                }
                txtQuantity.Text = row.Cells[4].Value.ToString();
                

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtImage.Text.Length==0)
                {
                    MessageBox.Show("You have to upload Image!", "Add fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    File.Copy(txtImage.Text, Path.Combine(@"C:\\Users\\user\\Desktop\\BookLibrary\\LibraryWinApp\\BookImages\\", Path.GetFileName(txtImage.Text)), true);
                    var newBook = new Book()
                    {
                        BookName = txtBookName.Text,
                        Category = txtCategory.Text,
                        Image = Path.GetFileName(txtImage.Text),
                        Quantity = int.Parse(txtQuantity.Text)
                    };
                    BookDAO.Instance.InsertBook(newBook);
                }
                

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            LoadAllBookList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var newBook = new Book()
                {
                    BookId = int.Parse(txtBookID.Text),
                    BookName = txtBookName.Text,
                    Category = txtCategory.Text,
                    Image = txtImage.Text,
                    Quantity = int.Parse(txtQuantity.Text)
                };

                BookDAO.Instance.UpdateBook(newBook);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            LoadAllBookList();
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    Book bookInfor = BookDAO.Instance.GetBookInfor(int.Parse(txtBookID.Text));
        //    string Image = bookInfor.Image;
        //    if (!bookInfor.Image.Equals(txtImage.Text))
        //    {
        //        File.Copy(txtImage.Text, Path.Combine(@"C:\\Users\\user\\Desktop\\BookLibrary\\LibraryWinApp\\BookImages\\", Path.GetFileName(txtImage.Text)), true);
        //        Image = Path.GetFileName(txtImage.Text);
        //    }
        //    try
        //    {
        //        var newBook = new Book()
        //        {
        //            BookId = int.Parse(txtBookID.Text),
        //            BookName = txtBookName.Text,
        //            Category = txtCategory.Text,
        //            Image = Image,
        //            Quantity = int.Parse(txtQuantity.Text)
        //        };

        //        BookDAO.Instance.UpdateBook(newBook);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);

        //    }
        //    LoadAllBookList();
        //}
        private Book GetBookObject()
        {
            Book book = null;
            try
            {
                book = new Book()
                {
                    BookId = int.Parse(txtBookID.Text),
                    BookName = txtBookName.Text,
                    Category = txtCategory.Text,
                    Image = txtImage.Text,
                    Quantity = int.Parse(txtQuantity.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get book");
            }
            return book;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this book!", "Delete Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {

                    var book = GetBookObject();
                    BookDAO.Instance.DeleteBook(book);
                    LoadAllBookList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a book");
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex!=0)
            {
                var historyList = BookDAO.Instance.GetBookListByCategory(cboCategory.Text);
                source = new BindingSource();
                source.DataSource = historyList;
                dgvBook.DataSource = null;
                dgvBook.DataSource = source;
            }
            else
            {
                LoadAllBookList();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.bmp;)|*.jpg; *.jepg; *.gif; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.Copy(txtFileName.Text, Path.Combine(@"C:\\Users\\user\\Desktop\\BookLibrary\\LibraryWinApp\\BookImages\\", Path.GetFileName(txtFileName.Text)),true);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtImage.Text = string.Empty;
            txtBookID.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            pictureBox1.Image = null;
            LoadAllBookList();
        }
    }
}
