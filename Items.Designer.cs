namespace Project
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            btnitemDelete = new Button();
            btnItemAdd = new Button();
            btnItemEdit = new Button();
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            txtStock = new TextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtItem = new TextBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            label8 = new Label();
            panel8 = new Panel();
            guna2ControlBox6 = new Guna.UI2.WinForms.Guna2ControlBox();
            label4 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1 = new Panel();
            label12 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lblLogout = new Label();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            category = new ComboBox();
            button1 = new Button();
            ItemView = new DataGridView();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemView).BeginInit();
            SuspendLayout();
            // 
            // btnitemDelete
            // 
            btnitemDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnitemDelete.BackColor = Color.Coral;
            btnitemDelete.BackgroundImageLayout = ImageLayout.None;
            btnitemDelete.FlatAppearance.BorderColor = Color.Black;
            btnitemDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnitemDelete.ForeColor = Color.BlanchedAlmond;
            btnitemDelete.Location = new Point(781, 234);
            btnitemDelete.Name = "btnitemDelete";
            btnitemDelete.Size = new Size(146, 42);
            btnitemDelete.TabIndex = 22;
            btnitemDelete.Text = "Delete";
            btnitemDelete.UseVisualStyleBackColor = false;
            btnitemDelete.Click += btnitemDelete_Click;
            // 
            // btnItemAdd
            // 
            btnItemAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnItemAdd.BackColor = Color.Coral;
            btnItemAdd.BackgroundImageLayout = ImageLayout.None;
            btnItemAdd.FlatAppearance.BorderColor = Color.Black;
            btnItemAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItemAdd.ForeColor = Color.BlanchedAlmond;
            btnItemAdd.Location = new Point(304, 234);
            btnItemAdd.Name = "btnItemAdd";
            btnItemAdd.Size = new Size(146, 42);
            btnItemAdd.TabIndex = 21;
            btnItemAdd.Text = "Add Item";
            btnItemAdd.UseVisualStyleBackColor = false;
            btnItemAdd.Click += btnItemAdd_Click;
            // 
            // btnItemEdit
            // 
            btnItemEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnItemEdit.BackColor = Color.Coral;
            btnItemEdit.BackgroundImageLayout = ImageLayout.None;
            btnItemEdit.FlatAppearance.BorderColor = Color.Black;
            btnItemEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItemEdit.ForeColor = Color.BlanchedAlmond;
            btnItemEdit.Location = new Point(540, 234);
            btnItemEdit.Name = "btnItemEdit";
            btnItemEdit.Size = new Size(146, 42);
            btnItemEdit.TabIndex = 20;
            btnItemEdit.Text = "Edit";
            btnItemEdit.UseVisualStyleBackColor = false;
            btnItemEdit.Click += btnItemEdit_Click;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.Location = new Point(1024, 156);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(174, 27);
            txtStock.TabIndex = 16;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1024, 120);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 17;
            label9.Text = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Location = new Point(781, 155);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(174, 27);
            txtPrice.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(781, 120);
            label7.Name = "label7";
            label7.Size = new Size(47, 23);
            label7.TabIndex = 15;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(530, 120);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 13;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(290, 120);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 11;
            label5.Text = "Product Name";
            // 
            // txtItem
            // 
            txtItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItem.Location = new Point(290, 154);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(174, 27);
            txtItem.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Coral;
            label8.Location = new Point(639, 58);
            label8.Name = "label8";
            label8.Size = new Size(109, 31);
            label8.TabIndex = 5;
            label8.Text = "Products";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Coral;
            panel8.Controls.Add(guna2ControlBox6);
            panel8.Controls.Add(label4);
            panel8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel8.Location = new Point(186, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1062, 44);
            panel8.TabIndex = 9;
            // 
            // guna2ControlBox6
            // 
            guna2ControlBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox6.BackColor = Color.DarkOrange;
            guna2ControlBox6.CustomizableEdges = customizableEdges4;
            guna2ControlBox6.FillColor = Color.SeaShell;
            guna2ControlBox6.IconColor = Color.Black;
            guna2ControlBox6.Location = new Point(1009, 12);
            guna2ControlBox6.Name = "guna2ControlBox6";
            guna2ControlBox6.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2ControlBox6.Size = new Size(41, 23);
            guna2ControlBox6.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Coral;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 7);
            label4.Name = "label4";
            label4.Size = new Size(299, 28);
            label4.TabIndex = 4;
            label4.Text = "Spareparts Management System ";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.bikelogo;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(35, 12);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(112, 108);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 4;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // panel6
            // 
            panel6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(186, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(183, 65);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel7.Location = new Point(186, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(896, 44);
            panel7.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 694);
            panel1.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SeaShell;
            label12.Location = new Point(36, 134);
            label12.Name = "label12";
            label12.Size = new Size(111, 31);
            label12.TabIndex = 27;
            label12.Text = "BIKER.LK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(83, 648);
            label10.Name = "label10";
            label10.Size = new Size(75, 28);
            label10.TabIndex = 30;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 637);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 416);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 0;
            label3.Text = "Sales";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 234);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 0;
            label2.Text = "Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 322);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 222);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Tomato;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblLogout);
            panel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(3, 744);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 65);
            panel4.TabIndex = 29;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogout.ForeColor = Color.White;
            lblLogout.Location = new Point(83, 18);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(75, 28);
            lblLogout.TabIndex = 0;
            lblLogout.Text = "Logout";
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Body Parts", "Moving Parts", "Lights", "Engine Parts", "Tyres", "Metal Parts", "Plastic Parts" });
            category.Location = new Point(530, 154);
            category.Name = "category";
            category.Size = new Size(174, 28);
            category.TabIndex = 24;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Coral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlanchedAlmond;
            button1.Location = new Point(1003, 234);
            button1.Name = "button1";
            button1.Size = new Size(146, 42);
            button1.TabIndex = 25;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ItemView
            // 
            ItemView.BackgroundColor = Color.SeaShell;
            ItemView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemView.Location = new Point(349, 322);
            ItemView.MultiSelect = false;
            ItemView.Name = "ItemView";
            ItemView.RowHeadersWidth = 51;
            ItemView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemView.Size = new Size(733, 343);
            ItemView.TabIndex = 26;
            ItemView.DoubleClick += ItemView_DoubleClick;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1248, 694);
            Controls.Add(ItemView);
            Controls.Add(button1);
            Controls.Add(category);
            Controls.Add(btnitemDelete);
            Controls.Add(btnItemAdd);
            Controls.Add(btnItemEdit);
            Controls.Add(label9);
            Controls.Add(txtStock);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtItem);
            Controls.Add(label8);
            Controls.Add(panel8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += MainPage_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Add the missing event handler method for label8_Click in the MainPage class.
        private void label8_Click(object sender, EventArgs e)
        {
            // Add your desired logic here. For now, it can be left empty if no specific functionality is required.
        }
        #endregion

        private Button btnitemDelete;
        private Button btnItemAdd;
        private Button btnItemEdit;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private TextBox txtStock;
        private Label label9;
        private TextBox txtPrice;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtItem;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label8;
        private Panel panel8;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel1;
        private Label txtManufacurer;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private ComboBox category;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label lblLogout;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox6;
        private DataGridView ItemView;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label10;
        private PictureBox pictureBox5;
        private Label label12;
    }
}