using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {

        public static string connectionsstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService_119;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionsstring);

        public bool AddDetails(AddressModelClass model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("spAddDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@ZipCode", model.ZipCode);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@EmailId", model.EmailId);
                   
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();

                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool DeleteContacts(string FirstName)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("spDeleteDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName",FirstName);
                    //command.Parameters.AddWithValue("@LastName", model.LastName);
                    //command.Parameters.AddWithValue("@Address", model.Address);
                    //command.Parameters.AddWithValue("@City", model.City);
                    //command.Parameters.AddWithValue("@State", model.State);
                    //command.Parameters.AddWithValue("@ZipCode", model.ZipCode);
                    //command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    //command.Parameters.AddWithValue("@EmailId", model.EmailId);

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();

                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool UpdateDetails(AddressModelClass model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("spEditDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@ZipCode", model.ZipCode);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@EmailId", model.EmailId);

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();

                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            finally
            {
                this.connection.Close();
            }
        }

    }
}
