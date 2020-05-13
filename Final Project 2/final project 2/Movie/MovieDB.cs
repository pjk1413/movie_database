using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Final_Project_2.Database;

namespace Final_Project_2.Genre_Form
{
    public static class MovieDB
    {
        public static List<Movie> GetMovie()
        {
            List<Movie> movieList = new List<Movie>();  //Establishes a list to load data into
            string SQLStatement =
                "SELECT movie_number, movie_title, Description, movie_year_made, genre_id, movie_rating, media_type, movie_retail_cost, copies_on_hand, image, trailer " +
                "FROM Movie";
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
                                Movie newMovie = new Movie();
                                newMovie.movie_number = Convert.ToInt32(Reader["movie_number"]);
                                newMovie.movie_title = Reader["movie_title"].ToString(); //Need to expand this to fill entire movie out
                                newMovie.Description = Reader["Description"].ToString();
                                newMovie.movie_year_made = Convert.ToInt32(Reader["movie_year_made"]);
                                newMovie.genre_id = Convert.ToInt32(Reader["genre_id"]);
                                newMovie.movie_rating = Reader["movie_rating"].ToString();
                                newMovie.media_type = Reader["media_type"].ToString();
                                newMovie.movie_retail_cost = Convert.ToInt32(Reader["movie_retail_cost"]);
                                newMovie.copies_on_hand = Convert.ToInt32(Reader["copies_on_hand"]);
                                newMovie.image = Reader["image"].ToString();
                                newMovie.trailer = Reader["trailer"].ToString();

                                //Add the Movie to the collection
                                movieList.Add(newMovie);
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
            return movieList;
        }

        public static Movie GetMovie(int movie_number)
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            //Genre objTemp = new Genre();

            string sqlString =
                "SELECT movie_number, movie_title, Description, movie_year_made, genre_id, movie_rating, media_type, movie_retail_cost, copies_on_hand, image, trailer " +
                "FROM Movie " +
                "WHERE movie_number = @movie_number ";
            SqlCommand Command = null;
            SqlConnection Conn = null;
            SqlDataReader Reader = null;
            Movie newMovie = null;
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
                        Command.Parameters.AddWithValue("@movie_number", movie_number);
                        //Execute the SQL and return a DataReader
                        using (Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                newMovie = new Movie();
                                //Fill the customer object if found
                                newMovie.movie_number = Convert.ToInt32(Reader["movie_number"]);
                                newMovie.movie_title = Reader["movie_title"].ToString();
                                newMovie.Description = Reader["Description"].ToString();
                                newMovie.movie_year_made = Convert.ToInt32(Reader["movie_year_made"]);
                                newMovie.genre_id = Convert.ToInt32(Reader["genre_id"]);
                                newMovie.movie_rating = Reader["movie_rating"].ToString();
                                newMovie.media_type = Reader["media_type"].ToString();
                                newMovie.movie_retail_cost = Convert.ToInt32(Reader["movie_retail_cost"]);
                                newMovie.copies_on_hand = Convert.ToInt32(Reader["copies_on_hand"]);
                                newMovie.image = Reader["image"].ToString();
                                newMovie.trailer = Reader["trailer"].ToString();
                            }
                        }
                    }
                    return newMovie;
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

        public static bool AddMovie(Movie objMovie)
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
                    sqlString = 
                        "INSERT INTO Movie " +
                        "VALUES (@movie_number, @movie_title, @Description, @movie_year_made, @genre_id, @movie_rating, @media_type, @movie_retail_cost, @copies_on_hand, " +
                        "@image, @trailer)";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        objCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                        objCommand.Parameters.AddWithValue("@Description", objMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                        objCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                        objCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                        objCommand.Parameters.AddWithValue("@media_type", objMovie.media_type);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", objMovie.movie_retail_cost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", objMovie.copies_on_hand);
                        objCommand.Parameters.AddWithValue("@image", objMovie.image);
                        objCommand.Parameters.AddWithValue("@trailer", objMovie.trailer);

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

        //This area needs updates still
        public static bool UpdateMovie(Movie objMovie)
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
                    sqlString = "UPDATE Movie " + Environment.NewLine +
                                "SET movie_title = @movie_title, Description = @Description, movie_year_made = @movie_year_made, genre_id = @genre_id, " +
                                "movie_rating =@movie_rating, media_type =@media_type, movie_retail_cost = @movie_retail_cost, copies_on_hand = @copies_on_hand, " +
                                "image = @image, trailer = @trailer " + Environment.NewLine +
                                "WHERE movie_number = @movie_number;";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        objCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                        objCommand.Parameters.AddWithValue("@Description", objMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                        objCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                        objCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                        objCommand.Parameters.AddWithValue("@media_type", objMovie.media_type);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", objMovie.movie_retail_cost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", objMovie.copies_on_hand);
                        objCommand.Parameters.AddWithValue("@image", objMovie.image);
                        objCommand.Parameters.AddWithValue("@trailer", objMovie.trailer);
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
                if (objConn != null)
                {
                    objConn.Close();
                }
            }

        }

        public static bool DeleteMovie(Movie objMovie)
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
                    sqlString = "DELETE Movie WHERE movie_number = @movie_number";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);

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
