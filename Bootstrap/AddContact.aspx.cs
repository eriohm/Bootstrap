using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Bootstrap
{
    public partial class WebForm2 : System.Web.UI.Page
    {
            const string CON_STR = "Data Source=ACADEMY029-VM;Initial Catalog=Contacts;Integrated Security=SSPI";
            List<Person> contactlist = new List<Person>();
        
        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = CON_STR;

            int newContactID = 0;

            //add person to database:
            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "spAddContact";

                SqlParameter paramSSN = new SqlParameter("@SSN", SqlDbType.VarChar);
                paramSSN.Value = TextBoxSSN.Text;
                myCommand.Parameters.Add(paramSSN);

                SqlParameter paramFirstname = new SqlParameter("@firstName", SqlDbType.VarChar);
                paramFirstname.Value = TextBoxFirstName.Text;
                myCommand.Parameters.Add(paramFirstname);

                SqlParameter paramLastname = new SqlParameter("@lastname", SqlDbType.VarChar);
                paramLastname.Value = TextBoxLastName.Text;
                myCommand.Parameters.Add(paramLastname);

                SqlParameter paramID = new SqlParameter("@new_id", SqlDbType.Int);
                paramID.Direction = ParameterDirection.Output;
                myCommand.Parameters.Add(paramID);

                int numberOfRows = myCommand.ExecuteNonQuery();
                Console.WriteLine($"Added {numberOfRows} row.");

                newContactID = (int)paramID.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }
            protected void TextBoxFirstName_TextChanged(object sender, EventArgs e)
            {

            }

            protected void TextBoxLastName_TextChanged(object sender, EventArgs e)
            {

            }

            protected void TextBoxSSN_TextChanged(object sender, EventArgs e)
            {

            }

            protected void TextBoxPhone_TextChanged(object sender, EventArgs e)
            {

            }

            protected void TextBoxStreet_TextChanged(object sender, EventArgs e)
            {

            }

            protected void TextBoxCity_TextChanged(object sender, EventArgs e)
            {

            }
        }

}
