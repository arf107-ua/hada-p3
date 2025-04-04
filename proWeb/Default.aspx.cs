using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace proWeb
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarCategory();
            }
        }

        private void CargarCategory()
        {
            CADCategory cadCategory = new CADCategory(); 
            List<ENCategory> categories = cadCategory.ReadAll(); 

            ddlCategory.Items.Clear();

            if (categories.Count == 0)
            {
                ddlCategory.Items.Add(new ListItem("No hay categorías disponibles", "-1"));
            }
            else
            {
                foreach (ENCategory category in categories)
                {
                    ddlCategory.Items.Add(new ListItem(category.Name, category.Id.ToString()));
                }
            }
        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    Amount = int.Parse(txtAmount.Text),
                    Price = float.Parse(txtPrice.Text),
                    Category = int.Parse(ddlCategory.SelectedValue),
                    CreationDate = DateTime.Parse(txtCreationDate.Text)
                };

                CADProduct cadProduct = new CADProduct();
                bool isCreated = cadProduct.Create(product);

                if (isCreated)
                {
                    lblMessage.Text = "Product created succesfully!";
                }
                else
                {
                    lblMessage.Text = "Error creating the product.";;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    Amount = int.Parse(txtAmount.Text),
                    Price = float.Parse(txtPrice.Text),
                    Category = int.Parse(ddlCategory.SelectedValue),
                    CreationDate = DateTime.Parse(txtCreationDate.Text) 
                };

                CADProduct cadProduct = new CADProduct();
                bool isUpdated = cadProduct.Update(product);

                if (isUpdated)
                {
                    lblMessage.Text = "Product updated successfully.";
                }
                else
                {
                    lblMessage.Text = "Error updating the product.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct { Code = txtCode.Text };
                CADProduct cadProduct = new CADProduct();
                bool isDeleted = cadProduct.Delete(product);

                if (isDeleted)
                {
                    lblMessage.Text = "Product deleted successfully.";

                    txtCode.Text = "";
                    txtName.Text = "";
                    txtAmount.Text = "";
                    txtPrice.Text = "";
                    txtCreationDate.Text = "";
                }
                else
                {
                    lblMessage.Text = "Error deleting the product.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct { Code = txtCode.Text };
                CADProduct cadProduct = new CADProduct();

                bool isRead = cadProduct.Read(product);

                if (isRead)
                {
                    txtName.Text = product.Name;
                    txtAmount.Text = product.Amount.ToString();
                    txtPrice.Text = product.Price.ToString();
                    ddlCategory.SelectedValue = product.Category.ToString();
                    txtCreationDate.Text = product.CreationDate.ToString("dd/MM/yyyy HH:mm:ss");

                    lblMessage.Text = "Product read successfully.";
                }
                else
                {
                    lblMessage.Text = "Product not found.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        }

        protected void btnReadFirst_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct();
                CADProduct cadProduct = new CADProduct();

                bool isRead = cadProduct.ReadFirst(product);

                if (isRead)
                {
                    txtCode.Text = product.Code;
                    txtName.Text = product.Name;
                    txtAmount.Text = product.Amount.ToString();
                    txtPrice.Text = product.Price.ToString();
                    ddlCategory.SelectedValue = product.Category.ToString();
                    txtCreationDate.Text = product.CreationDate.ToString("dd/MM/yyyy HH:mm:ss");

                    lblMessage.Text = "First product read.";
                }
                else
                {
                    lblMessage.Text = "No products available.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        }

        protected void btnReadPrev_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct { Code = txtCode.Text };  // Using the current product's code
                CADProduct cadProduct = new CADProduct();

                bool isRead = cadProduct.ReadPrev(product);

                if (isRead)
                {
                    txtCode.Text = product.Code;
                    txtName.Text = product.Name;
                    txtAmount.Text = product.Amount.ToString();
                    txtPrice.Text = product.Price.ToString();
                    ddlCategory.SelectedValue = product.Category.ToString();
                    txtCreationDate.Text = product.CreationDate.ToString("dd/MM/yyyy HH:mm:ss");

                    lblMessage.Text = "Previous product read.";
                }
                else
                {
                    lblMessage.Text = "No previous product available.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        }

        protected void btnReadNext_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct product = new ENProduct { Code = txtCode.Text };  // Using the current product's code
                CADProduct cadProduct = new CADProduct();

                bool isRead = cadProduct.ReadNext(product);

                if (isRead)
                {
                    txtCode.Text = product.Code;
                    txtName.Text = product.Name;
                    txtAmount.Text = product.Amount.ToString();
                    txtPrice.Text = product.Price.ToString();
                    ddlCategory.SelectedValue = product.Category.ToString();
                    txtCreationDate.Text = product.CreationDate.ToString("dd/MM/yyyy HH:mm:ss");

                    lblMessage.Text = "Next product read.";
                }
                else
                {
                    lblMessage.Text = "No next product available.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
        }
    }
}