using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Final_Project_2.Database;

namespace Final_Project_2.MemberFile
{
    public static class MemberDB
    {
        public static List<Member> GetMembers()
        {
            List<Member> memberList = new List<Member>();  
            string SQLStatement = 
                "SELECT * " +
                "FROM member " +
                "ORDER BY number";

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
                                Member newMember = new Member();

                                //These database calls need to be updated

                                newMember.memberNumber = Convert.ToInt32(Reader["number"]);
                                newMember.joinDate = Reader["joinDate"].ToString();
                                newMember.firstName = Reader["firstName"].ToString();
                                newMember.lastName = Reader["lastName"].ToString();
                                newMember.address = Reader["address"].ToString();
                                newMember.city = Reader["city"].ToString();
                                newMember.state = Reader["state"].ToString();
                                newMember.zipcode = Convert.ToInt32(Reader["zipcode"]);
                                //newMember.phoneNumber = Convert.ToInt32(Reader["phone"]);
                                newMember.status = Reader["member_status"].ToString();
                                newMember.login = Reader["login_name"].ToString();
                                newMember.password = Reader["password"].ToString();
                                newMember.email = Reader["email"].ToString();
                                newMember.contact_method = Convert.ToInt32(Reader["contact_method"]);
                                newMember.subscription_id = Convert.ToInt32(Reader["subscription_id"]);
                                newMember.photo = Reader["photo"].ToString();

                                //Add the genre to the collection
                                memberList.Add(newMember);
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

            return memberList;

        }

        public static Member GetMember(int number)
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            //Genre objTemp = new Genre();

            string sqlString = 
                "SELECT * " +
                "FROM Member " +
                "WHERE number = @number";
            SqlCommand Command = null;
            SqlConnection Conn = null;
            SqlDataReader Reader = null;
            Member newMember = null;
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
                        Command.Parameters.AddWithValue("@number", number);
                        //Execute the SQL and return a DataReader
                        using (Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                newMember = new Member();

                                //Fill the customer object if found
                                newMember.memberNumber = Convert.ToInt32(Reader["number"]);
                                newMember.joinDate = Reader["joinDate"].ToString();
                                newMember.firstName = Reader["firstName"].ToString();
                                newMember.lastName = Reader["lastName"].ToString();
                                newMember.address = Reader["address"].ToString();
                                newMember.city = Reader["city"].ToString();
                                newMember.state = Reader["state"].ToString();
                                newMember.zipcode = Convert.ToInt32(Reader["zipcode"]);
                                //newMember.phoneNumber = Convert.ToInt32(Reader["phone"]);
                                newMember.status = Reader["member_status"].ToString();
                                newMember.login = Reader["login_name"].ToString();
                                newMember.password = Reader["password"].ToString();
                                newMember.email = Reader["email"].ToString();
                                newMember.contact_method = Convert.ToInt32(Reader["contact_method"]);
                                newMember.subscription_id = Convert.ToInt32(Reader["subscription_id"]);
                                newMember.photo = Reader["photo"].ToString();
                            }
                        }
                    }
                    return newMember;
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

        public static bool AddMember(Member objMember)
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
                        "INSERT INTO Member " +
                        "VALUES (@number, @joindate, @firstName, @lastName, @address, @city, @state, @zipcode, @phone, @member_status, @login_name, @password, @email, @contact_method, @subscription_id, @photo)";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@number", objMember.memberNumber);
                        objCommand.Parameters.AddWithValue("@joindate", objMember.joinDate);
                        objCommand.Parameters.AddWithValue("@firstName", objMember.firstName);
                        objCommand.Parameters.AddWithValue("@lastName", objMember.lastName);
                        objCommand.Parameters.AddWithValue("@address", objMember.address);
                        objCommand.Parameters.AddWithValue("@city", objMember.city);
                        objCommand.Parameters.AddWithValue("@state", objMember.state);
                        objCommand.Parameters.AddWithValue("@zipcode", objMember.zipcode);
                        objCommand.Parameters.AddWithValue("@phone", objMember.phoneNumber);
                        objCommand.Parameters.AddWithValue("@member_status", objMember.status);
                        objCommand.Parameters.AddWithValue("@login_name", objMember.login);
                        objCommand.Parameters.AddWithValue("@password", objMember.password);
                        objCommand.Parameters.AddWithValue("@email", objMember.email);
                        objCommand.Parameters.AddWithValue("@contact_method", objMember.contact_method);
                        objCommand.Parameters.AddWithValue("@subscription_id", objMember.subscription_id);
                        objCommand.Parameters.AddWithValue("@photo", objMember.photo);

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

        public static bool UpdateMember(Member objMember)
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
                    sqlString = 
                        "UPDATE Member " + 
                        "SET joindate = @joindate, firstName = @firstName, lastName = @lastName, address = @address, city = @city, state = @state, zipcode = @zipcode, phone = @phone,  " +
                        "member_status = @member_status, login_name = @login_name, password = @password, email = @email, contact_method = @contact_method, subscription_id = @subscription_id, photo = @photo " +
                        "WHERE number = @number ";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@number", objMember.memberNumber);
                        objCommand.Parameters.AddWithValue("@joindate", objMember.joinDate);
                        objCommand.Parameters.AddWithValue("@firstName", objMember.firstName);
                        objCommand.Parameters.AddWithValue("@lastName", objMember.lastName);
                        objCommand.Parameters.AddWithValue("@address", objMember.address);
                        objCommand.Parameters.AddWithValue("@city", objMember.city);
                        objCommand.Parameters.AddWithValue("@state", objMember.state);
                        objCommand.Parameters.AddWithValue("@zipcode", objMember.zipcode);
                        objCommand.Parameters.AddWithValue("@phone", objMember.phoneNumber);
                        objCommand.Parameters.AddWithValue("@member_status", objMember.status);
                        objCommand.Parameters.AddWithValue("@login_name", objMember.login);
                        objCommand.Parameters.AddWithValue("@password", objMember.password);
                        objCommand.Parameters.AddWithValue("@email", objMember.email);
                        objCommand.Parameters.AddWithValue("@contact_method", objMember.contact_method);
                        objCommand.Parameters.AddWithValue("@subscription_id", objMember.subscription_id);
                        objCommand.Parameters.AddWithValue("@photo", objMember.photo);

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

        public static bool DeleteMember(Member objMember)
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
                    sqlString = 
                        "DELETE Member " +
                        "WHERE number = @number";

                    //Create a command object with the SQL statement
                    using (objCommand = new SqlCommand(sqlString, objConn))
                    {
                        //Use the command parameters method to set the paramater values of the SQL Insert statement
                        objCommand.Parameters.AddWithValue("@number", objMember.memberNumber);

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
