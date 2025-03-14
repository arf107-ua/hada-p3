using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proWeb
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Product created successfully!";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Product updated successfully!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Product deleted successfully!";
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Product details retrieved!";
        }

        protected void btnReadFirst_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "First product read!";
        }

        protected void btnReadPrev_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Previous product read!";
        }

        protected void btnReadNext_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Next product read!";
        }
    }
}