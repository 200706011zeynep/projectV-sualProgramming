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
    public partial class EmployeeSignIn : Form
    {
        public EmployeeSignIn()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection (@"Data Source=LAPTOP-M2VPS2J3;Initial Catalog=visualProgramming;Integrated Security=True");
        private void employeeSignInButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from employeeTable where employeeUsername='" + employeeUsernameTextBox.Text + "'employeePassword = '" + employeePasswordTextBox.Text + "'  employeeJobTitle = '" + employeeTitleTextBox.Text , sqlConnection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                ProductSettingForm frm = new ProductSettingForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Employee login is unsuccesful");
            }
            sqlConnection.Close();



        }
    }
}
