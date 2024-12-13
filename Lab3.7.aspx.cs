using System;

namespace Lab3DikshyaShahi{
    public partial class Default : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e)
        {}
            protected void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    // Get values from input fields
                    double principal = Convert.ToDouble(txtPrincipal.Text);
                    double rate = Convert.ToDouble(txtRate.Text);
                    double time = Convert.ToDouble(txtTime.Text);

                    // Calculate Simple Interest
                    double simpleInterest = (principal * rate * time) / 100;

                    // Display the result
                    lblResult.Text = $"Simple Interest is: {simpleInterest}";
                }
                catch (Exception ex)
                {
                    lblResult.Text = $"Error: {ex.Message}";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }

