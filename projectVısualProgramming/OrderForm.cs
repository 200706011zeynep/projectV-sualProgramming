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

namespace projectVısualProgramming
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-M2VPS2J3;Initial Catalog=visualProgramming;");
        private void OrderForm_Load(object sender, EventArgs e)
        {
            fillin();
        }
        private void fillin()
        {
            sqlConnection.Open();
            string query = "select * from [productTable]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable table = new DataTable();
            adapter.Fill(table);

            orderDataGrid.DataSource = table;
            sqlConnection.Close();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                int value = int.Parse(productNameBox.Text);

                string query = "insert into [OrderConfirmation](customerOrder,orderRecieved)values(@customerOrder,@orderRecieved)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@customerOrder", value);
                sqlCommand.Parameters.AddWithValue("@orderRecieved", productQuantityBox.Text);

                int rowsAffect = sqlCommand.ExecuteNonQuery();
                if (rowsAffect <= 0)
                {
                    MessageBox.Show("Error order is not created ");

                }
                else
                {
                    MessageBox.Show("Order created succesfully ");
                }
                sqlConnection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error order is not created ");
            }
        }

        
    }
}
