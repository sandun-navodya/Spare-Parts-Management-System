using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Project
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            LoadData2();
        }

        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=SparePartsDb;Integrated Security=True");
        private decimal currentPrice = 0.0m; // Variable to store the current price of the selected product
        private void LoadData2()
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sales", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

        private void ResetFields()
        {
            CusIDS.Text = "";
            CusNameS.Text = "";
            ProID.Text = "";
            ProNameS.Text = "";
            QuaS.Text = "";
            TotS.Text = "";
            dateTimePicker1.Text = "";
        }

        private void LoadCustomerID()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM Customers", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CusIDS.Items.Add(reader["CustomerID"].ToString());
                }
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

        private void LoadProductID()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductID FROM Products", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProID.Items.Add(reader["ProductID"].ToString());
                }
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




        private void Sales_Load(object sender, EventArgs e)
        {
            LoadCustomerID();
            LoadProductID();

            Color customcolor = Color.FromArgb(255, 178, 102); // Custom color for the panel
            dataGridView1.EnableHeadersVisualStyles = false; // Disable default header styles
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = customcolor; // Set custom header background color
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Set header text color to white
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);// Set header font style

            dataGridView1.DefaultCellStyle.SelectionBackColor = customcolor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White; // Set selected row text color to white
            dataGridView1.GridColor = Color.LightGray; // Set grid line color to light gray

            //  PrintDocument.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CusIDS.Text == "" || ProID.Text == "" || QuaS.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
            }

            int quantitySold;
            if (!int.TryParse(QuaS.Text, out quantitySold) || quantitySold <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.");
                return;
            }
            try
            {
                connection.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT Quantity , Price FROM Products Where ProductID = @ProductID", connection);
                cmd1.Parameters.AddWithValue("@ProductID", ProID.Text);
                SqlDataReader reader = cmd1.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Product Not Found");
                    connection.Close();
                    return;
                }

                int availableQty = Convert.ToInt32(reader["Quantity"]);
                decimal unitPrice = Convert.ToDecimal(reader["Price"]);
                reader.Close();

                if (quantitySold > availableQty)
                {
                    MessageBox.Show("Stock is not available");
                    return;
                }

                decimal totalAmount = quantitySold * unitPrice;

                SqlCommand insert = new SqlCommand("INSERT INTO Sales (CustomerID,CustomerName,ProductID,ProductName,QuantitySold,TotalAmount,SaleDate) VALUES (@CustomerID,@CustomerName,@ProductID,@ProductName,@QuantitySold,@TotalAmount,@SaleDate)", connection);
                insert.Parameters.AddWithValue("@CustomerID", CusIDS.Text);
                insert.Parameters.AddWithValue("@CustomerName", CusNameS.Text);
                insert.Parameters.AddWithValue("@ProductID", ProID.Text);
                insert.Parameters.AddWithValue("@ProductName", ProNameS.Text);
                insert.Parameters.AddWithValue("@QuantitySold", QuaS.Text);
                insert.Parameters.AddWithValue("@TotalAmount", totalAmount);
                insert.Parameters.AddWithValue("@SaleDate", dateTimePicker1.Value);
                insert.ExecuteNonQuery();

                SqlCommand updateStock = new SqlCommand("UPDATE Products SET Quantity = Quantity - @QuantitySold WHERE ProductID = @ProductID", connection);
                updateStock.Parameters.AddWithValue("@QuantitySold", quantitySold);
                updateStock.Parameters.AddWithValue("@ProductID", ProID.Text);
                updateStock.ExecuteNonQuery();
                connection.Close();

                LoadData2();
                ResetFields();
                MessageBox.Show("Sale recorded successfully.");
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


        private void label10_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }



        private void ProID_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT ProductName, Price FROM Products WHERE ProductID=@ProductID", connection);
            cmd.Parameters.AddWithValue("@ProductID", ProID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ProNameS.Text = reader["ProductName"].ToString();
                currentPrice = Convert.ToDecimal(reader["Price"]);

                // Calculate total using current quantity if available
                int quantity = 1;
                if (int.TryParse(QuaS.Text, out int q))
                    quantity = q;

                TotS.Text = (currentPrice * quantity).ToString("0.00");
            }
            connection.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void CusIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT CustomerName FROM Customers WHERE CustomerID = @CustomerID", connection);
            cmd.Parameters.AddWithValue("@CustomerID", CusIDS.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CusNameS.Text = reader["CustomerName"].ToString();
            }
            connection.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }



        private void QuaS_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(QuaS.Text, out int qty))
            {
                decimal total = currentPrice * qty;
                TotS.Text = total.ToString("0.00");
            }
            else
            {
                TotS.Text = "0.00"; // Reset to 0 if input is invalid
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a sale to update");
                return;
            }

            if (string.IsNullOrWhiteSpace(CusIDS.Text) || string.IsNullOrWhiteSpace(ProID.Text) ||
                string.IsNullOrWhiteSpace(QuaS.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            int SaleID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SaleID"].Value);
            int oldQty = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QuantitySold"].Value);
            string oldProductID = dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // First restore the old quantity
                            SqlCommand restoreCmd = new SqlCommand(
                                "UPDATE Products SET Quantity = Quantity + @oldQty WHERE ProductID = @oldProductID",
                                conn, transaction);
                            restoreCmd.Parameters.AddWithValue("@oldQty", oldQty);
                            restoreCmd.Parameters.AddWithValue("@oldProductID", oldProductID);
                            restoreCmd.ExecuteNonQuery();

                            // Check available stock for new quantity
                            SqlCommand stockCheck = new SqlCommand(
                                "SELECT Quantity FROM Products WHERE ProductID = @ProductID",
                                conn, transaction);
                            stockCheck.Parameters.AddWithValue("@ProductID", ProID.Text);
                            int currentStock = Convert.ToInt32(stockCheck.ExecuteScalar());
                            int newQty = Convert.ToInt32(QuaS.Text);

                            if (newQty > currentStock)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Insufficient stock available.");
                                return;
                            }

                            // Update the sale record
                            decimal totalAmount = newQty * currentPrice;
                            SqlCommand updateSale = new SqlCommand(@"
                                UPDATE Sales 
                                SET CustomerID = @CustomerID, 
                                    CustomerName = @CustomerName, 
                                    ProductID = @ProductID, 
                                    ProductName = @ProductName, 
                                    QuantitySold = @QuantitySold, 
                                    TotalAmount = @TotalAmount, 
                                    SaleDate = @SaleDate 
                                WHERE SaleID = @SaleID", conn, transaction);

                            updateSale.Parameters.AddWithValue("@CustomerID", CusIDS.Text);
                            updateSale.Parameters.AddWithValue("@CustomerName", CusNameS.Text);
                            updateSale.Parameters.AddWithValue("@ProductID", ProID.Text);
                            updateSale.Parameters.AddWithValue("@ProductName", ProNameS.Text);
                            updateSale.Parameters.AddWithValue("@QuantitySold", newQty);
                            updateSale.Parameters.AddWithValue("@TotalAmount", totalAmount);
                            updateSale.Parameters.AddWithValue("@SaleDate", dateTimePicker1.Value);
                            updateSale.Parameters.AddWithValue("@SaleID", SaleID);
                            updateSale.ExecuteNonQuery();

                            // Update the product stock
                            SqlCommand updateStock = new SqlCommand(
                                "UPDATE Products SET Quantity = Quantity - @newQty WHERE ProductID = @ProductID",
                                conn, transaction);
                            updateStock.Parameters.AddWithValue("@newQty", newQty);
                            updateStock.Parameters.AddWithValue("@ProductID", ProID.Text);
                            updateStock.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Sale updated and stock adjusted successfully.");
                            LoadData2();
                            ResetFields();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Error updating sale: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Debug: Show selected rows count and current row index
            MessageBox.Show(
                $"SelectedRows.Count: {dataGridView1.SelectedRows.Count}\n" +
                $"CurrentRow Index: {(dataGridView1.CurrentRow != null ? dataGridView1.CurrentRow.Index.ToString() : "null")}\n" +
                $"Rows.Count: {dataGridView1.Rows.Count}"
            );

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a sale to delete.");
                return;
            }

            try
            {
                int SaleID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SaleID"].Value);
                int quantityRestore = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QuantitySold"].Value);
                string ProductID = dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString();

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to delete this sale? This will also restore the stock.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
                    {
                        conn.Open();
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Restore product stock first
                                SqlCommand updateStockCmd = new SqlCommand(
                                    "UPDATE Products SET Quantity = Quantity + @quantityRestore WHERE ProductID = @ProductID",
                                    conn, transaction);
                                updateStockCmd.Parameters.AddWithValue("@quantityRestore", quantityRestore);
                                updateStockCmd.Parameters.AddWithValue("@ProductID", ProductID);
                                int stockUpdated = updateStockCmd.ExecuteNonQuery();

                                if (stockUpdated <= 0)
                                {
                                    throw new Exception("Failed to restore product stock.");
                                }

                                // Then delete the sale
                                SqlCommand deleteCmd = new SqlCommand(
                                    "DELETE FROM Sales WHERE SaleID = @SaleID",
                                    conn, transaction);
                                deleteCmd.Parameters.AddWithValue("@SaleID", SaleID);
                                int saleDeleted = deleteCmd.ExecuteNonQuery();

                                if (saleDeleted <= 0)
                                {
                                    throw new Exception("Failed to delete sale record.");
                                }

                                transaction.Commit();
                                MessageBox.Show("Sale deleted and stock restored successfully.");
                                LoadData2();
                                ResetFields();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception("Error during delete operation: " + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                CusIDS.Text = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
                CusNameS.Text = dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();
                ProID.Text = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
                ProNameS.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
                QuaS.Text = dataGridView1.CurrentRow.Cells["QuantitySold"].Value.ToString();
                TotS.Text = dataGridView1.CurrentRow.Cells["TotalAmount"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["SaleDate"].Value.ToString();
            }
        }

        // Add this event handler to ensure clicking a cell selects the row
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
            saveFileDialog.Title = "Save Sales Report";
            saveFileDialog.FileName = "SalesReport.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dataGridView1, saveFileDialog.FileName);
            }
        }


        private void ExportToPDF(DataGridView dgv, string filename)
        {
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph("Sales Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(dgv.Columns.Count);
            table.WidthPercentage = 100;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(230, 230, 230);
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            doc.Add(table);
            doc.Close();

            MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
    



