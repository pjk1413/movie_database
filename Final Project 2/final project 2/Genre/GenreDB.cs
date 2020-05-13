using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Final_Project_2.Database;

namespace Final_Project_2.Genre_Form
{
    public static class GenreDB
    {
        public static List<Genre> GetGenres()
        {
            List<Genre> genreList = new List<Genre>();  //Establishes a list to load data into
            string SQLStatement = "select id, name from genre order by id";
            SqlCommand Command = null;
            SqlConnection Conn = null;
            SqlDataReader Reader = null;

            try
            {
                using (Conn = AccessDB.GetConnection())
                {
                    //Open the connection to the database
                    Conn.Open();
                    //Create a command object with the SQL statement
                    using (Command = new SqlCommand(SQLStatement, Conn))
                    {
                        //Execute the SQL and return a DataReader Object
                        using (Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Genre newGenre = new Genre();
                                newGenre.ID = Convert.ToInt32(Reader["ID"]);
                                newGenre.Name = Reader["Name"].ToString();

                                //Add the genre to the collection
                                genreList.Add(newGenre);
                            }
                        }
                    }

                } 

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Close();
                }
            }

            return genreList;

        }

        public static Genre GetGenre(int genreID)
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            //Genre objTemp = new Genre();

            string sqlString = "Select id, name from genre where id = @genre_id ";
            SqlCommand Command = null;
            SqlConnection Conn = null;
            SqlDataReader Reader = null;
            Genre newGenre = null;
            try
            {
                using (Conn = AccessDB.GetConnection())
                {
                    //Open the connection to the datbase
                    Conn.Open();
                    //Create a command object with the SQL statement
                    using (Command = new SqlCommand(sqlString, Conn))
                    {
                        //Set command parameter
                        Command.Parameters.AddWithValue("@genre_id", genreID);
                        //Execute the SQL and return a DataReader
                        using (Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                newGenre = new Genre();
                                //Fill the customer object if found
                                newGenre.ID = Convert.ToInt32(Reader["ID"]);
                                newGenre.Name = Reader["Name"].ToString();
                            }
                        }
                    }
                    return newGenre;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (Conn != null)
                {
                    Conn.Close();
                }
            }

        }

        public static bool AddGenre(Genre objGenre)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to insert data in the underline database table 
            string SQLStatement = String.Empty;

            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;
            try
            {
                using (objConn = AccessDB.GetConnection())
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    sqlString = "INSERT into Genre values (@genre_id, @genre_name)";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@genre_id", objGenre.ID);
                        objCommand.Parameters.AddWithValue("@genre_name", objGenre.Name);
                        //Execute the SQL and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }
            }
        }

        public static bool UpdateGenre(Genre objGenre)
        {
            string SQLStatement = String.Empty;

            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;
            try
            {
                using (objConn = AccessDB.GetConnection())
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    sqlString = "UPDATE Genre " + Environment.NewLine +
                                "set name = @genre_name " + Environment.NewLine +
                                "where id = @genre_id ";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@genre_name", objGenre.Name);
                        objCommand.Parameters.AddWithValue("@genre_id", objGenre.ID);
                        //Execute the SQL and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }
            }

        }

        public static bool DeleteGenre(Genre objGenre)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to insert data in the underline database table 
            string SQLStatement = String.Empty;
            //Uncomment either Example #1 or #2 to use appropriate connection string
            //Example #1 for connecting to a remote SQL Server instance via IP address and SQL Server authenication..For Meramec
            //string connectionString = "Server=mc-sluggo.stlcc.edu;Database=IS253_251;User Id=csharp2;Password=csharp2;";

            //Example #2 for connecting to SQL Server locally with Windows Authenication. Change accordingly to your environment.
            //string connectionString = @"Data Source=STEVIE-LAPTOP\MSSQLSERVER1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            int rowsAffected = 0;

            SqlCommand objCommand = null;
            SqlConnection objConn = null;

            string sqlString;
            try
            {
                using (objConn = AccessDB.GetConnection())
                {
                    //Open the connection to the datbase
                    objConn.Open();
                    sqlString = "Delete Genre where id = @genre_id";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@genre_id", objGenre.ID);

                        //Execute the SQL and return the number of rows affected
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Finally will always be called in a try..catch..statem. You can use to to close the connection
                //especially if an error is thrown
                if (objConn != null)
                {
                    objConn.Close();
                }
            }
        }


    }
}
