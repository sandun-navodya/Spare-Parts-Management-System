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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            LoadData1();
        }

        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS ; Initial Catalog=SparePartsDb;Integrated Security=True");
        private void LoadData1()
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                ItemView1.DataSource = dataTable;
                connection.Close();

                //Color customcolor = Color.FromArgb(255, 178, 102); // Custom color for the panel
                //ItemView1.EnableHeadersVisualStyles = false; // Disable default header styles
                //ItemView1.ColumnHeadersDefaultCellStyle.BackColor = customcolor; // Set custom header background color
                //ItemView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Set header text color to white
                //ItemView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Set header font style

                //ItemView1.DefaultCellStyle.SelectionBackColor = customcolor;
                //ItemView1.DefaultCellStyle.SelectionForeColor = Color.White; // Set selected row text color to white
                //ItemView1.GridColor = Color.LightGray; // Set grid line color to light gray


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

        private void ResetFields()
        {
            textBox1.Text = "";
            txtemail.Text = "";
            txtCusPhone.Text = "";

        }


        private void label2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ResetFields();
        }


        private void label15_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemView1.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(ItemView1.SelectedRows[0].Cells[0].Value);
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID=@CustomerID", connection);
                    cmd.Parameters.AddWithValue("@CustomerID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully.");
                    connection.Close();
                    LoadData1();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = txtCusPhone.Text.Trim();
            string email = txtemail.Text.Trim();

            // Validate phone
            if (!Regex.IsMatch(phone, @"^\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid phone number (10-15 digits).");
                return;
            }

            // Validate email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (CustomerName,Phone, Email) VALUES (@CustomerName, @Phone, @Email)", connection);
                cmd.Parameters.AddWithValue("@CustomerName", textBox1.Text);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                connection.Close();
                LoadData1();
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




        private void ItemView1_DoubleClick(object sender, EventArgs e)
        {
            if (ItemView1.CurrentRow != null && ItemView1.CurrentRow.Index != -1)
            {
                textBox1.Text = ItemView1.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtCusPhone.Text = ItemView1.CurrentRow.Cells["Phone"].Value.ToString();
                txtemail.Text = ItemView1.CurrentRow.Cells["Email"].Value.ToString();


            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (ItemView1.SelectedRows.Count > 0)
            {
                string phone = txtCusPhone.Text.Trim();
                string email = txtemail.Text.Trim();

                // Validate phone
                if (!Regex.IsMatch(phone, @"^\d{10,15}$"))
                {
                    MessageBox.Show("Please enter a valid phone number (10-15 digits).");
                    return;
                }

                // Validate email
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                int id = Convert.ToInt32(ItemView1.SelectedRows[0].Cells[0].Value);

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customers SET CustomerName=@CustomerName, Phone=@Phone, Email=@Email WHERE CustomerID=@CustomerID", connection);

                    cmd.Parameters.AddWithValue("@CustomerID", id);
                    cmd.Parameters.AddWithValue("@CustomerName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully.");
                    connection.Close();
                    LoadData1();
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
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
