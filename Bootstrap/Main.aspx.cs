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
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string CON_STR = "Data Source=ACADEMY029-VM;Initial Catalog=Contacts;Integrated Security=SSPI";
        List<Person> contactlist = new List<Person>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBoxContacts.Items.Clear();
            LoadContacts();
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

            protected void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selID = ListBoxContacts.SelectedIndex;
            if (selID >= 0 )
            {
                Response.Redirect("EditContact.aspx?id=" + ListBoxContacts.SelectedValue);

            }

        

        }

    }
}