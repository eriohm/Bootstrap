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
    public partial class WebForm3 : System.Web.UI.Page
    {
            const string CON_STR = "Data Source=ACADEMY029-VM;Initial Catalog=Contacts;Integrated Security=SSPI";
            List<Person> contactlist = new List<Person>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //create int to save index! Will be cleared ever time page reloads.
            int index = ListBoxContacts.SelectedIndex;

            ListBoxContacts.Items.Clear();
            LoadContacts();

            //re-set index!
            ListBoxContacts.SelectedIndex = index;
        }

        private void LoadContacts()
        {
            SqlConnection myConnection = new SqlConnection(CON_STR);
            SqlCommand myCommand = new SqlCommand("select * from Contact", myConnection);

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                //clear to avoid duplicates!
                contactlist.Clear();

                while (myReader.Read())
                {
                    string id = myReader["contactID"].ToString();
                    string fName = myReader["firstName"].ToString();
                    string lName = myReader["lastName"].ToString();
                    string ssn = myReader["SSN"].ToString();

                    contactlist.Add(new Person(id, fName, lName, ssn));
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('{ex.Message}');</script>");
            }
            finally
            {
                myConnection.Close();
            }

            foreach (var tmpContact in contactlist)
            {
                ListItem tmpItem = new ListItem($"{tmpContact.fName} {tmpContact.lName} {tmpContact.ssn}", tmpContact.id);
                ListBoxContacts.Items.Add(tmpItem);
            }

            if (!IsPostBack)
            {
                int selIndex = ListBoxContacts.SelectedIndex;
                ListBoxContacts.Items.Clear();

                foreach (var tmpContact in contactlist)
                {
                    ListItem tmpItem = new ListItem($"{tmpContact.fName} {tmpContact.lName} {tmpContact.ssn}", tmpContact.id);
                    ListBoxContacts.Items.Add(tmpItem);
                }

                if (selIndex > 0)
                    ListBoxContacts.SelectedIndex = selIndex;
            }


        }

        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(CON_STR);
            string contactID = ListBoxContacts.SelectedValue;

            try
            {
                myConnection.Open();

                string query = $"remove contact where contactID={Convert.ToInt32(contactID)}";

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = query;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

            ListBoxContacts.Items.Clear();
            LoadContacts();
        }

        protected void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}