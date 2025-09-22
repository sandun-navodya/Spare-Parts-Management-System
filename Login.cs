using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializePasswordField();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)

        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS ; Initial Catalog=SparePartsDb;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT COUNT(*) FROM Login WHERE UserName=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {


                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializePasswordField()
        {
            // Set initial password char
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // More readable way to toggle password visibility
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

      
    }
}
