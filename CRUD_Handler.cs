using System;
using System.Windows.Forms;

namespace MovieRentalSystem2020
{
    class CRUD_Handler
    {
        CRUD myCRUD = new CRUD();
        public string AddDataHandler(string[] Data, string TableName)
        {
            switch (TableName)
            {
                case "Customer":
                    //Check if the data has the complete amount
                    if (Data.Length == 5)
                    {
                        //Checks each data in the array if they are empty
                        foreach (string data in Data)
                        {
                            if (data == String.Empty)
                            {
                                return "Please fill all the fields!";
                            }
                        }

                        //if all data has values then submit
                        return myCRUD.AddData(Data, TableName);
                    }
                    break;
                case "Movies":
                    {
                        for (int i = 0; i < Data.Length; i++)
                        {
                            if (Data[0] == String.Empty || Data[1] == String.Empty || Data[2] == String.Empty || Data[5] == String.Empty)
                            {
                                return "Please fill the required fields marked as *";
                            }
                            else
                            {
                                return myCRUD.AddData(Data, TableName);
                            }
                        }
                    }
                    break;
                case "RentedMovies":
                    {
                        for (int i = 0; i < Data.Length; i++)
                        {
                            if (Data[0] == String.Empty)
                            {
                                return "Please select the Movie that is being issued";
                            }
                            else if (Data[1] == String.Empty)
                            {
                                return "Please select the Customer";
                            }
                            else
                            {
                                return myCRUD.AddData(Data, TableName);
                            }
                        }
                    }
                    break;
            }

            return null;
        }

        public string DeleteDataHandler(int Id, string TableName)
        {
            switch (TableName)
            {
                case "Customer":
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        return myCRUD.DeleteData(Id, TableName);
                    }
                    else
                    {
                        return "Deletion Cancelled";
                    }

                case "Movies":

                    var movieConfirm = MessageBox.Show("Are you sure to delete this item ??",
                 "Confirm Deletion",

                 MessageBoxButtons.YesNo);
                    if (movieConfirm == DialogResult.Yes)
                    {
                        return myCRUD.DeleteData(Id, TableName);
                    }
                    else
                    {
                        return "Deletion Cancelled";
                    }
            }
            return null;
        }

        public string UpdateDataHandler(string[] Data, string TableName)
        {
            switch (TableName)
            {
                case "Customer":
                    //Check if the data has the complete amount
                    if (Data.Length == 6)
                    {
                        //Checks each data in the array if they are empty
                        foreach (string data in Data)
                        {
                            if (data == String.Empty)
                            {
                                return "Please fill all the fields!";
                            }
                        }

                        //if all data has values then submit
                        return myCRUD.UpdateData(Data, TableName);
                    }
                    break;

                case "Movies":
                    for (int i = 0; i < Data.Length; i++)
                    {
                        if (Data[0] == String.Empty || Data[1] == String.Empty || Data[2] == String.Empty || Data[5] == String.Empty)
                        {
                            return "Please fill the required fields marked as *";
                        }
                        else
                        {
                            return myCRUD.UpdateData(Data, TableName);
                        }
                    }
                    break;
            }

            return null;
        }

        public string ReturnMovieHandler(string[] Data, string TableName)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data[0] == String.Empty)
                {
                    return "Please select the Movie that is being issued";
                }
                else if (Data[1] == String.Empty)
                {
                    return "Please select the Customer";
                }
                else
                {
                    return myCRUD.ReturnMovie(Data, TableName);
                }
            }
            return null;
        }
    }
}
