namespace MovieRentalSystem2020
{
    partial class Form1
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
            this.tbctrlPopularMovies = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvRented = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvPopularMovies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFname = new System.Windows.Forms.TextBox();
            this.tbxLname = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAddr = new System.Windows.Forms.TextBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.tbxMovieID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.tbxCopies = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxPlot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDateMovie = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxRating = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblRentedMovieID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxDateReturned = new System.Windows.Forms.TextBox();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.rbShowBorrowedMovies = new System.Windows.Forms.RadioButton();
            this.rbShowMostPopularMovies = new System.Windows.Forms.RadioButton();
            this.rbShowWhoBuysMost = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tbctrlPopularMovies.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRented)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularMovies)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlPopularMovies
            // 
            this.tbctrlPopularMovies.Controls.Add(this.tabPage1);
            this.tbctrlPopularMovies.Controls.Add(this.tabPage2);
            this.tbctrlPopularMovies.Controls.Add(this.tabPage3);
            this.tbctrlPopularMovies.Controls.Add(this.tabPage4);
            this.tbctrlPopularMovies.Location = new System.Drawing.Point(1, 2);
            this.tbctrlPopularMovies.Name = "tbctrlPopularMovies";
            this.tbctrlPopularMovies.SelectedIndex = 0;
            this.tbctrlPopularMovies.Size = new System.Drawing.Size(1484, 275);
            this.tbctrlPopularMovies.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1476, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 3);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1470, 240);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomersCell_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1476, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.Size = new System.Drawing.Size(1470, 240);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRented);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1476, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rented Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvRented
            // 
            this.dgvRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRented.Location = new System.Drawing.Point(3, 3);
            this.dgvRented.Name = "dgvRented";
            this.dgvRented.RowHeadersWidth = 51;
            this.dgvRented.RowTemplate.Height = 24;
            this.dgvRented.Size = new System.Drawing.Size(1470, 240);
            this.dgvRented.TabIndex = 0;
            this.dgvRented.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRented_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvPopularMovies);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1476, 246);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Filtered Lists";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvPopularMovies
            // 
            this.dgvPopularMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopularMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPopularMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvPopularMovies.Name = "dgvPopularMovies";
            this.dgvPopularMovies.RowHeadersWidth = 51;
            this.dgvPopularMovies.RowTemplate.Height = 24;
            this.dgvPopularMovies.Size = new System.Drawing.Size(1470, 240);
            this.dgvPopularMovies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // tbxFname
            // 
            this.tbxFname.Location = new System.Drawing.Point(10, 70);
            this.tbxFname.Name = "tbxFname";
            this.tbxFname.Size = new System.Drawing.Size(150, 22);
            this.tbxFname.TabIndex = 2;
            // 
            // tbxLname
            // 
            this.tbxLname.Location = new System.Drawing.Point(10, 122);
            this.tbxLname.Name = "tbxLname";
            this.tbxLname.Size = new System.Drawing.Size(150, 22);
            this.tbxLname.TabIndex = 2;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(10, 172);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(150, 22);
            this.tbxPhone.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(191, 215);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(251, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(216, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Joined:";
            // 
            // tbxAddr
            // 
            this.tbxAddr.Location = new System.Drawing.Point(10, 222);
            this.tbxAddr.Name = "tbxAddr";
            this.tbxAddr.Size = new System.Drawing.Size(150, 22);
            this.tbxAddr.TabIndex = 2;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(333, 64);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(120, 45);
            this.btnEditCustomer.TabIndex = 4;
            this.btnEditCustomer.Text = "Edit Details";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(333, 11);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(120, 45);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(334, 120);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(120, 45);
            this.btnRemoveCustomer.TabIndex = 4;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // tbxMovieID
            // 
            this.tbxMovieID.Location = new System.Drawing.Point(111, 17);
            this.tbxMovieID.Name = "tbxMovieID";
            this.tbxMovieID.ReadOnly = true;
            this.tbxMovieID.Size = new System.Drawing.Size(106, 22);
            this.tbxMovieID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Movie:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRemoveCustomer);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.btnEditCustomer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.tbxCustomerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxAddr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxFname);
            this.panel1.Controls.Add(this.tbxLname);
            this.panel1.Controls.Add(this.tbxPhone);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(7, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 263);
            this.panel1.TabIndex = 7;
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(172, 20);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.ReadOnly = true;
            this.tbxCustomerID.Size = new System.Drawing.Size(106, 22);
            this.tbxCustomerID.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbxGenre);
            this.panel2.Controls.Add(this.btnDeleteMovie);
            this.panel2.Controls.Add(this.tbxCopies);
            this.panel2.Controls.Add(this.btnAddMovie);
            this.panel2.Controls.Add(this.btnEditMovie);
            this.panel2.Controls.Add(this.tbxYear);
            this.panel2.Controls.Add(this.tbxPlot);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dtpDateMovie);
            this.panel2.Controls.Add(this.tbxMovieID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbxCost);
            this.panel2.Controls.Add(this.tbxTitle);
            this.panel2.Controls.Add(this.tbxRating);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(508, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 283);
            this.panel2.TabIndex = 8;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(10, 243);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(100, 22);
            this.tbxGenre.TabIndex = 2;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(366, 143);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteMovie.TabIndex = 4;
            this.btnDeleteMovie.Text = "Remove Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // tbxCopies
            // 
            this.tbxCopies.Location = new System.Drawing.Point(10, 195);
            this.tbxCopies.Name = "tbxCopies";
            this.tbxCopies.Size = new System.Drawing.Size(100, 22);
            this.tbxCopies.TabIndex = 2;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(366, 11);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(120, 45);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add New Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Location = new System.Drawing.Point(366, 75);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(120, 45);
            this.btnEditMovie.TabIndex = 4;
            this.btnEditMovie.Text = "Edit Movie Details";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(10, 140);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 22);
            this.tbxYear.TabIndex = 2;
            // 
            // tbxPlot
            // 
            this.tbxPlot.Location = new System.Drawing.Point(138, 195);
            this.tbxPlot.Name = "tbxPlot";
            this.tbxPlot.Size = new System.Drawing.Size(100, 22);
            this.tbxPlot.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Title *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(136, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Genre *";
            // 
            // dtpDateMovie
            // 
            this.dtpDateMovie.Location = new System.Drawing.Point(138, 245);
            this.dtpDateMovie.Name = "dtpDateMovie";
            this.dtpDateMovie.Size = new System.Drawing.Size(251, 22);
            this.dtpDateMovie.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Copies";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Plot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Rental Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Year *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rating *";
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(138, 140);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(100, 22);
            this.tbxCost.TabIndex = 2;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(138, 75);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(100, 22);
            this.tbxTitle.TabIndex = 2;
            // 
            // tbxRating
            // 
            this.tbxRating.Location = new System.Drawing.Point(10, 75);
            this.tbxRating.Name = "tbxRating";
            this.tbxRating.Size = new System.Drawing.Size(100, 22);
            this.tbxRating.TabIndex = 2;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.Lime;
            this.btnIssue.Location = new System.Drawing.Point(5, 585);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(1023, 59);
            this.btnIssue.TabIndex = 9;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReturn.Location = new System.Drawing.Point(1058, 585);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(395, 59);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1055, 549);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "RentedMovie ID:";
            // 
            // lblRentedMovieID
            // 
            this.lblRentedMovieID.AutoSize = true;
            this.lblRentedMovieID.Location = new System.Drawing.Point(1173, 549);
            this.lblRentedMovieID.Name = "lblRentedMovieID";
            this.lblRentedMovieID.Size = new System.Drawing.Size(16, 17);
            this.lblRentedMovieID.TabIndex = 11;
            this.lblRentedMovieID.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1055, 453);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(326, 51);
            this.label17.TabIndex = 12;
            this.label17.Text = "Select the curstomer who\'s returning\r\na movie then Select the Movie that is being" +
    " \r\nreturned under RentedMovies.";
            // 
            // tbxDateReturned
            // 
            this.tbxDateReturned.Enabled = false;
            this.tbxDateReturned.Location = new System.Drawing.Point(1222, 549);
            this.tbxDateReturned.Name = "tbxDateReturned";
            this.tbxDateReturned.Size = new System.Drawing.Size(159, 22);
            this.tbxDateReturned.TabIndex = 13;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.rbShowBorrowedMovies);
            this.pnlFilters.Controls.Add(this.rbShowMostPopularMovies);
            this.pnlFilters.Controls.Add(this.rbShowWhoBuysMost);
            this.pnlFilters.Location = new System.Drawing.Point(314, 667);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(723, 50);
            this.pnlFilters.TabIndex = 14;
            // 
            // rbShowBorrowedMovies
            // 
            this.rbShowBorrowedMovies.AutoSize = true;
            this.rbShowBorrowedMovies.Location = new System.Drawing.Point(487, 14);
            this.rbShowBorrowedMovies.Name = "rbShowBorrowedMovies";
            this.rbShowBorrowedMovies.Size = new System.Drawing.Size(233, 21);
            this.rbShowBorrowedMovies.TabIndex = 1;
            this.rbShowBorrowedMovies.TabStop = true;
            this.rbShowBorrowedMovies.Text = "Show Movies currently borrowed";
            this.rbShowBorrowedMovies.UseVisualStyleBackColor = true;
            this.rbShowBorrowedMovies.CheckedChanged += new System.EventHandler(this.rbShowBorrowedMovies_CheckedChanged);
            // 
            // rbShowMostPopularMovies
            // 
            this.rbShowMostPopularMovies.AutoSize = true;
            this.rbShowMostPopularMovies.Location = new System.Drawing.Point(250, 14);
            this.rbShowMostPopularMovies.Name = "rbShowMostPopularMovies";
            this.rbShowMostPopularMovies.Size = new System.Drawing.Size(198, 21);
            this.rbShowMostPopularMovies.TabIndex = 0;
            this.rbShowMostPopularMovies.TabStop = true;
            this.rbShowMostPopularMovies.Text = "Show Most Popular Movies";
            this.rbShowMostPopularMovies.UseVisualStyleBackColor = true;
            this.rbShowMostPopularMovies.CheckedChanged += new System.EventHandler(this.rbShowMostPopularMovies_CheckedChanged);
            // 
            // rbShowWhoBuysMost
            // 
            this.rbShowWhoBuysMost.AutoSize = true;
            this.rbShowWhoBuysMost.Location = new System.Drawing.Point(17, 14);
            this.rbShowWhoBuysMost.Name = "rbShowWhoBuysMost";
            this.rbShowWhoBuysMost.Size = new System.Drawing.Size(184, 21);
            this.rbShowWhoBuysMost.TabIndex = 0;
            this.rbShowWhoBuysMost.TabStop = true;
            this.rbShowWhoBuysMost.Text = "Show Who borrows Most";
            this.rbShowWhoBuysMost.UseVisualStyleBackColor = true;
            this.rbShowWhoBuysMost.CheckedChanged += new System.EventHandler(this.rbShowWhoBuysMost_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(488, 647);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Filters for the Filtered Lists";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 729);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.tbxDateReturned);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblRentedMovieID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbctrlPopularMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbctrlPopularMovies.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRented)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularMovies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlPopularMovies;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvRented;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFname;
        private System.Windows.Forms.TextBox tbxLname;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAddr;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.TextBox tbxMovieID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxCopies;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxRating;
        private System.Windows.Forms.TextBox tbxPlot;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDateMovie;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRentedMovieID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxDateReturned;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvPopularMovies;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.RadioButton rbShowMostPopularMovies;
        private System.Windows.Forms.RadioButton rbShowWhoBuysMost;
        private System.Windows.Forms.RadioButton rbShowBorrowedMovies;
        private System.Windows.Forms.Label label18;
    }
}
