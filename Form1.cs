using System;
using System.Windows.Forms;

namespace MovieRentalSystem2020
{
    public partial class Form1 : Form
    {
        CRUD myCRUD = new CRUD();
        CRUD_Handler myCRUDHandler = new CRUD_Handler();
        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }

        private void LoadDB()
        {
            dgvCustomers.DataSource = myCRUD.ReadEntries("Customer");

            dgvMovies.DataSource = myCRUD.ReadEntries("Movies");

            dgvRented.DataSource = myCRUD.ReadEntries("RentedMovies");

            string query = "SELECT Title, count(*) as Amount FROM RentedMoviesxCustomers GROUP BY Title ORDER BY Amount DESC";
            dgvPopularMovies.DataSource = myCRUD.MostPopular(query);
        }

        private void dgvCustomersCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //display value of the data
                string cellValue = dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = cellValue;

                //array of textboxes
                TextBox[] textBoxes = { tbxCustomerID, tbxFname, tbxLname, tbxPhone, tbxAddr };

                //display data in the text boxes
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i].Text = dgvCustomers.Rows[e.RowIndex].Cells[i].Value.ToString();
                }

                string date = dgvCustomers.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (date == "") //checks if there is a date recorded in the database
                {
                    //if none then display the date today
                    dtpDate.Value = DateTime.Now;
                }
                else
                {
                    //otherwise change the value of the dateTimePicker to the one in the database
                    dtpDate.Value = DateTime.Parse(date);
                    //dgvCustomers.Rows[e.RowIndex].Cells[5].Value.ToString();
                }

                dgvRented.DataSource = myCRUD.CustomerRentedMovies(tbxCustomerID.Text);
            }
            catch (Exception i)
            {
                Console.WriteLine(i);
            }
        }

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //display value of the data
                string cellValue = dgvMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = cellValue;

                //array of textboxes
                TextBox[] textBoxes = { tbxMovieID, tbxRating, tbxTitle, tbxYear, tbxCost, tbxCopies, tbxPlot, tbxGenre };

                //display data in the text boxes
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i].Text = dgvMovies.Rows[e.RowIndex].Cells[i].Value.ToString();
                }

                string date = dgvMovies.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (date == String.Empty) //checks if there is a date recorded in the database
                {
                    //if none then display the date today
                    dtpDate.Value = DateTime.Now;
                }
                else
                {
                    //otherwise change the value of the dateTimePicker to the one in the database
                    dtpDate.Value = DateTime.Parse(date);
                    //dgvCustomers.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception i)
            {
                Console.WriteLine(i);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //define an array to define the data
            string[] Data = { tbxFname.Text, tbxLname.Text, tbxAddr.Text, tbxPhone.Text, dtpDate.Value.ToString() };

            MessageBox.Show(myCRUDHandler.AddDataHandler(Data, "Customer"));

            LoadDB();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myCRUDHandler.DeleteDataHandler(Int32.Parse(tbxCustomerID.Text), "Customer"));

            LoadDB();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            //define an array to define the data
            string[] Data = { tbxFname.Text, tbxLname.Text, tbxAddr.Text, tbxPhone.Text, dtpDate.Value.ToString(), tbxCustomerID.Text };

            MessageBox.Show(myCRUDHandler.UpdateDataHandler(Data, "Customer"));

            LoadDB();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string[] Data = { tbxRating.Text, tbxTitle.Text, tbxYear.Text, tbxCost.Text, tbxCopies.Text, tbxPlot.Text, tbxGenre.Text, dtpDate.Value.ToString() };

            MessageBox.Show(myCRUDHandler.AddDataHandler(Data, "Movies"));

            LoadDB();
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myCRUDHandler.DeleteDataHandler(Int32.Parse(tbxMovieID.Text), "Movies"));

            LoadDB();
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            //define an array to define the data
            string[] Data = { tbxRating.Text, tbxTitle.Text, tbxYear.Text, tbxCost.Text, tbxCopies.Text, tbxPlot.Text, tbxGenre.Text, dtpDate.Value.ToString(), tbxMovieID.Text };

            MessageBox.Show(myCRUDHandler.UpdateDataHandler(Data, "Movies"));

            LoadDB();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string[] Data = { tbxMovieID.Text, tbxCustomerID.Text, DateTime.Now.ToString() };

            //Validation for charging customers
            if (tbxYear.Text == String.Empty || tbxCost.Text == String.Empty)
            {
                MessageBox.Show("Movie selected is missing a year and rental cost");
            }
            else
            {
                MessageBox.Show(myCRUDHandler.AddDataHandler(Data, "RentedMovies") + myCRUD.CostFee(tbxYear.Text, tbxCost.Text));

                LoadDB();
            }
        }

        //Return a movie
        private void btnReturn_Click(object sender, EventArgs e)
        {
            {
                if (lblRentedMovieID.Text == "0")
                {
                    MessageBox.Show("Select a Rented Movie under the Rented Movie Grid ");
                }
                else if (tbxDateReturned.Text != String.Empty)
                {
                    MessageBox.Show("This movie has already been returned");
                }
                else
                {
                    string[] Data = { lblRentedMovieID.Text, DateTime.Now.ToString() };

                    MessageBox.Show(myCRUDHandler.ReturnMovieHandler(Data, "RentedMovies"));
                    dgvRented.DataSource = myCRUD.CustomerRentedMovies(tbxCustomerID.Text);

                    LoadDB();
                }
            }
        }

        //Get the id and returned date of the rented movie
        private void dgvRented_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblRentedMovieID.Text = dgvRented.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxDateReturned.Text = dgvRented.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception i)
            {
                Console.WriteLine(i);
            }
        }


        //Filters the view to show popular movies
        private void rbShowMostPopularMovies_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Title, count(*) as Amount FROM RentedMoviesxCustomers GROUP BY Title ORDER BY Amount DESC";
            dgvPopularMovies.DataSource = myCRUD.MostPopular(query);

            this.Text = "Most Popular Movies";
        }

        //filters the view to show the customer who rents the most
        private void rbShowWhoBuysMost_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT FirstName, LastName, count(*) as Amount FROM RentedMoviesxCustomers GROUP BY FirstName, LastName ORDER BY Amount DESC";
            dgvPopularMovies.DataSource = myCRUD.MostPopular(query);

            this.Text = "Customers who buy the most";
        }

        //filters the view to show the movies that are currently not returned
        private void rbShowBorrowedMovies_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM RentedMoviesxCustomers WHERE DateReturned = '' OR DateReturned IS NULL ";
            dgvPopularMovies.DataSource = myCRUD.MostPopular(query);

            this.Text = "Movies that are currently out";
        }
    }
}
