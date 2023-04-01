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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account Acc = AccountDAO.Instance.GetAccByEmailPassword(txtEmail.Text, txtPassword.Text);

            if (Acc != null && Acc.Role == 1)
            {
                frmLibraryManagement frmMemberManagements = new frmLibraryManagement()
                {
                    LoginInfor = Acc
                };
                frmMemberManagements.ShowDialog();

            }
            else if (Acc != null && Acc.Role == 2)
            {
                frmStudentInterface frmMemberManagements = new frmStudentInterface()
                {
                    LoginInfor = Acc
                };
                frmMemberManagements.ShowDialog();

            }
            else
            {
                MessageBox.Show("Email or Password is incorrect, Please enter again!", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
