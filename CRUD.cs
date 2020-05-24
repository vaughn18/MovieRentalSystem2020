using System;
using System.Data;
using System.Data.SqlClient;

namespace MovieRentalSystem2020
{
    public class CRUD
    {
        private SqlConnection Connection = new SqlConnection(); //connect to db
        private SqlCommand Command = new SqlCommand();   //give it a query
        private SqlDataAdapter dataAdapter = new SqlDataAdapter(); //hold the results

        public CRUD()
        {
            string connectionString = @"Data Source=LAPTOP-OFH1E4JK;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //setting up Connection 
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        //This function fill DGVs with the Data
        public DataTable ReadEntries(string tableName)
        {
            //Define Table to hold data
            DataTable dt = new DataTable();

            string query = "select * from " + tableName;

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                //connect to db
                Connection.Open();

                //fill table with data
                dataAdapter.Fill(dt);

                Connection.Close();
            }
            //return "success"; //this is for unit testing purposes
            return dt;
        }

        //This function will display the selected Customer's rented movies
        public DataTable CustomerRentedMovies(string CustID)
        {
            Int32.Parse(CustID);

            DataTable dt = new DataTable();

            string query = "SELECT RentedMovies.RMID, Customer.FirstName, Customer.LastName, Movies.Title, RentedMovies.DateReturned,  RentedMovies.DateRented, Movies.Rental_Cost FROM RentedMovies INNER JOIN Customer ON RentedMovies.CustIDFK = Customer.CustID INNER JOIN Movies ON RentedMovies.MovieIDFK = Movies.MovieID WHERE RentedMovies.CustIDFK = " + CustID;


            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                //connect to db
                Connection.Open();

                //fill table with data
                dataAdapter.Fill(dt);

                Connection.Close();
            }
            return dt;
        }

        //Displays the list of the most rented movies and customer who borrows the most
        public DataTable MostPopular(string query)
        {
            DataTable dt = new DataTable();

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                //connect to db
                Connection.Open();

                //fill table with data
                dataAdapter.Fill(dt);

                Connection.Close();
            }
            return dt;
        }

        public string AddData(string[] Data, string TableName)
        {
            switch (TableName)
            {
                case "Customer":

                    // Define Add query
                    string query = "INSERT INTO " + TableName + " (FirstName, LastName, Address, Phone, Date) VALUES (@FirstName, @LastName, @Address, @Phone, @Date)";

                    string[] parameters = { "@FirstName", "@LastName", "@Address", "@Phone", "@Date" };

                    using (SqlCommand addData = new SqlCommand(query, Connection))
                    {
                        //parameter assignment of values to avoid sql Injection
                        for (int i = 0; i < Data.Length; i++)
                        {
                            addData.Parameters.AddWithValue(parameters[i], Data[i]);
                        }

                        // Open database connection
                        Connection.Open();

                        //returns how many rows were affected
                        int returnValue = addData.ExecuteNonQuery();

                        Connection.Close();

                        if (returnValue == 1)
                        {
                            return "New Customer added successfully";
                        }
                        else
                        {
                            return "Data submission failed";
                        }
                    }

                case "Movies":
                    // Define Add query
                    string movieQuery = "INSERT INTO " + TableName + " (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre, Date) VALUES (@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre, @Date)";

                    string[] movieParameters = { "@Rating", "@Title", "@Year", "@Rental_Cost", "@Copies", "@Plot", "@Genre", "@Date" };

                    using (SqlCommand addData = new SqlCommand(movieQuery, Connection))
                    {
                        //parameter assignment of values to avoid sql Injection
                        for (int i = 0; i < Data.Length; i++)
                        {
                            addData.Parameters.AddWithValue(movieParameters[i], Data[i]);
                        }

                        // Open database connection
                        Connection.Open();

                        //returns how many rows were affected
                        int returnValue = addData.ExecuteNonQuery();

                        Connection.Close();

                        if (returnValue == 1)
                        {
                            return "New Movie added successfully";
                        }
                        else
                        {
                            return "Data submission failed";
                        }
                    }

                case "RentedMovies":// this is the function to issue movies
                    // Define Add query
                    string issueQuery = "INSERT INTO " + TableName + " (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieID, @CustID, @Date)";

                    string[] issueParameters = { "@MovieID", "@CustID", "@Date" };

                    //convert the ids to int
                    Int32.Parse(Data[0]);
                    Int32.Parse(Data[1]);

                    using (SqlCommand addData = new SqlCommand(issueQuery, Connection))
                    {
                        //parameter assignment of values to avoid sql Injection
                        for (int i = 0; i < Data.Length; i++)
                        {
                            addData.Parameters.AddWithValue(issueParameters[i], Data[i]);
                        }

                        // Open database connection
                        Connection.Open();

                        //returns how many rows were affected
                        int returnValue = addData.ExecuteNonQuery();

                        Connection.Close();

                        if (returnValue == 1)
                        {
                            return "Movie has been issued successfully";
                        }
                        else
                        {
                            return "Movie issue failed";
                        }
                    }
            }

            return null;
        }

        public string DeleteData(int Id, string TableName)
        {
            switch (TableName)
            {
                case "Customer":
                    //sql query to delete
                    string query = "DELETE FROM " + TableName + " WHERE CustID = @ID";

                    // Define DB Connection
                    using (SqlCommand deleteData = new SqlCommand(query, Connection))
                    {
                        // Assign Parameters
                        deleteData.Parameters.AddWithValue("@ID", Id);

                        // Opens Connection to DB
                        Connection.Open();

                        // Executes SQL Command - Will return how many rows were effected
                        int returnValue = deleteData.ExecuteNonQuery();

                        // Closes Connection to DB
                        Connection.Close();

                        if (returnValue == 1)
                        {
                            return "Customer successfully removed";
                        }
                        else
                        {
                            return "Customer Deletion failed";
                        }
                    }

                case "Movies":
                    {
                        //sql query to delete
                        string movieQuery = "DELETE FROM " + TableName + " WHERE MovieID = @ID";

                        // Define DB Connection
                        using (SqlCommand deleteData = new SqlCommand(movieQuery, Connection))
                        {
                            // Assign Parameters
                            deleteData.Parameters.AddWithValue("@ID", Id);

                            // Opens Connection to DB
                            Connection.Open();

                            // Executes SQL Command - Will return how many rows were effected
                            int returnValue = deleteData.ExecuteNonQuery();

                            // Closes Connection to DB
                            Connection.Close();

                            if (returnValue == 1)
                            {
                                return "Movie successfully removed";
                            }
                            else
                            {
                                return "Movie Deletion failed";
                            }
                        }
                    }
            }
            return null;
        }

        public string UpdateData(string[] Data, string TableName)
        {
            switch (TableName)
            {
                case "Customer":
                    // Define Update Statement
                    string query = "UPDATE " + TableName + " SET FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone, Date = @Date WHERE CustID = @ID ";

                    string[] parameters = { "@FirstName", "@LastName", "@Address", "@Phone", "@Date", "@ID" };

                    // Define DB Connection
                    using (SqlCommand updateData = new SqlCommand(query, Connection))
                    {
                        // Opens Connection to DB
                        Connection.Open();

                        //parameter assignment of values to avoid sql Injection
                        for (int i = 0; i < Data.Length; i++)
                        {
                            updateData.Parameters.AddWithValue(parameters[i], Data[i]);
                        }

                        // Executes SQL Command - Will return how many rows were effected
                        int returnValue = updateData.ExecuteNonQuery();

                        // Closes Connection to DB
                        Connection.Close();

                        if (returnValue == 1)
                        {
                            return "Customer successfully updated";
                        }
                        else
                        {
                            return "Customer update failed";
                        }
                    }

                case "Movies":
                    // Define Update Statement
                    string movieQuery = "UPDATE " + TableName + " SET Rating = @Rating, Title = @Title, Year = @Year, Rental_Cost = @Cost, Copies = @Copies, Plot = @Plot, Genre = @Genre, Date = @Date WHERE MovieID = @ID ";

                    string[] movieParameters = { "@Rating", "@Title", "@Year", "@Cost", "@Copies", "@Plot", "@Genre", "@Date", "@ID" };

                    // Define DB Connection
                    using (SqlCommand updateData = new SqlCommand(movieQuery, Connection))
                    {
                        // Opens Connection to DB
                        Connection.Open();

                        //parameter assignment of values to avoid sql Injection
                        for (int i = 0; i < Data.Length; i++)
                        {
                            updateData.Parameters.AddWithValue(movieParameters[i], Data[i]);
                        }

                        // Executes SQL Command - Will return how many rows were effected
                        int returnValue = updateData.ExecuteNonQuery();

                        // Closes Connection to DB
                        Connection.Close();

                        if (returnValue == 1)
                        {
                            return "Movie successfully updated";
                        }
                        else
                        {
                            return "Movie update failed";
                        }
                    }
            }
            return null;
        }

        public string ReturnMovie(string[] Data, string TableName)
        {
            //sql query
            string query = "UPDATE " + TableName + " SET DateReturned = @Date WHERE RMID =" + Data[0];

            Int32.Parse(Data[0]);

            // Define DB Connection
            using (SqlCommand returnData = new SqlCommand(query, Connection))
            {
                // Opens Connection to DB
                Connection.Open();

                //parameter assignment of values to avoid sql Injection
                returnData.Parameters.AddWithValue("@Date", Data[1]);

                // Executes SQL Command - Will return how many rows were effected
                int returnValue = returnData.ExecuteNonQuery();

                // Closes Connection to DB
                Connection.Close();

                if (returnValue == 1)
                {
                    return "Movie successfully returned";
                }
                else
                {
                    return "Movie return failed";
                }
            }
        }

        //Charge Customers different fee base on release year
        public string CostFee(string year, string cost)
        {
            //checks if year has a value or not
            if (year == String.Empty)
            {
                return "Please add a year for the movie";
            }
            else
            {
                float finalCost = float.Parse(cost);

                //sql query
                string query = "UPDATE Movies SET Rental_Cost = @Cost";

                float movieYear = Int32.Parse(year);

                float currentYear = Int32.Parse(DateTime.Today.ToString("yyyy")) - 5000;

                if (movieYear < currentYear)
                {
                    finalCost = 2;
                }
                else
                {
                    finalCost = 5;
                }


                // Define DB Connection
                using (SqlCommand returnData = new SqlCommand(query, Connection))
                {
                    // Opens Connection to DB
                    Connection.Open();

                    //parameter assignment of values to avoid sql Injection
                    returnData.Parameters.AddWithValue("@Cost", cost);

                    // Executes SQL Command - Will return how many rows were effected
                    int returnValue = returnData.ExecuteNonQuery();

                    // Closes Connection to DB
                    Connection.Close();
                }
                return "Customer has been charged $" + finalCost + ".00";
            }
        }
    }
}
