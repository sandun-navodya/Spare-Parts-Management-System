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
using System.Xml.Linq;

namespace Project
{
    public partial class MainPage : Form
    {

        private object tabControl1;

        public MainPage()
        {

            InitializeComponent();
            LoadCustomer();

        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS ; Initial Catalog=SparePartsDb;Integrated Security=True");
        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }



        private void LoadCustomer()
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                ItemView.DataSource = dataTable;
                connection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }


        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            if (ItemView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(ItemView.SelectedRows[0].Cells[0].Value);

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName=@ProductName, Category=@Category, Quantity=@Quantity, Price=@Price WHERE ProductID=@ProductID", connection);
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    cmd.Parameters.AddWithValue("@ProductName", txtItem.Text);
                    cmd.Parameters.AddWithValue("@Category", category.Text);
                    cmd.Parameters.AddWithValue("@Quantity", decimal.Parse(txtStock.Text));
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully.");
                    connection.Close();
                    LoadCustomer();
                    ResetFields();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                finally
                {
                    connection.Close();
                }

            }

        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName,Category,Quantity,Price) VALUES (@ProductName,@Category,@Quantity,@Price)", connection);
                cmd.Parameters.AddWithValue("@ProductName", txtItem.Text);
                cmd.Parameters.AddWithValue("@Category", category.Text);
                cmd.Parameters.AddWithValue("@Quantity", decimal.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
                connection.Close();
                LoadCustomer();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnitemDelete_Click(object sender, EventArgs e)
        {
            if (ItemView.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(ItemView.SelectedRows[0].Cells[0].Value);
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID=@ProductID", connection);
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully.");
                    connection.Close();
                    LoadCustomer();
                    ResetFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }


        private void ResetFields()
        {
            txtItem.Text = "";
            category.Text = "";
            txtStock.Text = "";
            txtPrice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFields();
        }






        private void label1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ItemView_DoubleClick(object sender, EventArgs e)
        {
            if (ItemView.CurrentRow != null && ItemView.CurrentRow.Index != -1)
            {
                txtItem.Text = ItemView.CurrentRow.Cells["ProductName"].Value.ToString();
                txtPrice.Text = ItemView.CurrentRow.Cells["Price"].Value.ToString();
                txtStock.Text = ItemView.CurrentRow.Cells["Quantity"].Value.ToString();
                category.Text = ItemView.CurrentRow.Cells["Category"].Value.ToString();

            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
