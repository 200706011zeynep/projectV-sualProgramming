using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace projectVısualProgramming
{
    public partial class CustomerLogInForm : Form
    {
        public CustomerLogInForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-M2VPS2J3;Initial Catalog=visualProgramming;Integrated Security=True");
        private void LogInButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from customerTable where customerUsername='" + usernameTextBox.Text + "'customerPassword= '"  + PasswordTextBox.Text , sqlConnection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                OrderForm frm = new OrderForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("login is unsuccesful");
            }
            sqlConnection.Close();
        }

      
    }
}
