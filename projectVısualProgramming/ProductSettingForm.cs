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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectVısualProgramming
{
    public partial class ProductSettingForm : Form
    {
        public ProductSettingForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-M2VPS2J3;Initial Catalog=visualProgramming;");


        private void fillin()
        {
            sqlConnection.Open();
            string query = "select * from [productTable]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable table = new DataTable();
            adapter.Fill(table);

            productDataGrid.DataSource = table;
            sqlConnection.Close();
        }
        private void ProductSettings_Load(object sender, EventArgs e)
        {
            fillin();
        }


        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into [productTable](productName,productId,productPrice,productQuantity,productWeight)values(@productName,@productId,@productPrice,@productQuantity,@productWeight)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@productName", productNameBox.Text);
                command.Parameters.AddWithValue("@productId", productIdBox.Text);
                command.Parameters.AddWithValue("@productPrice", productprice.Text);
                command.Parameters.AddWithValue("@productQuantity", productQuantityBox.Text);
                command.Parameters.AddWithValue("@productWeight", productWeightBox.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("PRODUCT ADDED SUCCESFULLY");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteProductButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from [productTable] where productId=" + productIdBox.Text + "";
                SqlCommand command = new SqlCommand(query, sqlConnection);


                command.ExecuteNonQuery();
                MessageBox.Show("PRODUCT DELETED SUCCESFULLY");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            productNameBox.Clear();
            productIdBox.Clear();
            productprice.Clear();
            productQuantityBox.Clear();
            productWeightBox.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                int value = int.Parse(textBox2.Text);
                string query = "UPDATE [productTable] Set productQuantity = productQuantity - @quantity where productName = @productName ";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@quantity", value);
                command.Parameters.AddWithValue("@productName", textBox1.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("ORDER CONFIRMED");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CAN NOT CONFIRM ORDER");
            }
        }
    }
}
