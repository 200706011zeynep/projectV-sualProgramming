using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectVısualProgramming
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void CustomerSignInButton_Click(object sender, EventArgs e)
        {
            CustomerLogInForm frm = new CustomerLogInForm();
            frm.Show();
        }

        private void customerSignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm frm = new SignUpForm();
            frm.Show();
        }

        private void employeeLogInButton_Click(object sender, EventArgs e)
        {
            EmployeeSignIn frm = new EmployeeSignIn();
            frm.Show();
        }
    }
}