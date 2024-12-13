using System;
using System.Web.UI;

namespace PKMC2078Unit4Web
{
    public partial class Lab38 : Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Trim the input values
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // You can now process the trimmed values or save them to the database
            // Example: Display a success message
            lblMessage.Visible = true;
            lblMessage.Text = "Registration successful for " + name;

            // Optionally, clear the fields after submission
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}
