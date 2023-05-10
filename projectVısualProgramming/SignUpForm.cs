using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace projectVısualProgramming
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-M2VPS2J3;Initial Catalog=visualProgramming;");

        private void SignUpButton2_Click(object sender, EventArgs e)
        {
            string query = "insert into [customerTable](customerName,customerSurname,customerEmail,customerAdress,customerPassword,customerUsername,customerPhoneNumber)values(@customerName,@customerSurname,@customerEmail,@customerAdress,@customerPassword,@customerUsername,@customerPhoneNumber)";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@customerName", nameTextBox.Text);
            command.Parameters.AddWithValue("@customerSurname", surnameTextBox.Text);
            command.Parameters.AddWithValue("@customerEmail", eMailTextBox.Text);
            command.Parameters.AddWithValue("@customerUsername", userNameTextBox2.Text);
            command.Parameters.AddWithValue("@customerPassword", passwordTextBox2.Text);
            command.Parameters.AddWithValue("@customerAdress", addressTextBox.Text);
            command.Parameters.AddWithValue("@customerPhoneNumber", numberTextBox.Text);
            sqlConnection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("REGISTER SUCCESFULL");
            sqlConnection.Close();
        }

        private void signUpButton2_Click(object sender, EventArgs e)
        {
            CustomerLogInForm frm = new CustomerLogInForm();
            frm.Show();
        }
    }
}
