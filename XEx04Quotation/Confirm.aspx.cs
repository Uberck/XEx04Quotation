using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!(Session["SalesPrice"] == null))
            {
                decimal salesPrice = (decimal)Session["SalesPrice"];
                decimal discountAmount = (decimal)Session["DiscountAmount"];
                decimal totalPrice = (decimal)Session["TotalPrice"];
                lblSalesPrice.Text = salesPrice.ToString("c");
                lblDiscountAmount.Text = discountAmount.ToString("c");
                lblTotalPrice.Text = totalPrice.ToString("c");
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["SalesPrice"] = null;
                Session["DiscountAmount"] = null;
                Session["TotalPrice"] = null;

                string name = txtName.Text;
                string email = txtEmail.Text;
                lblMessage.Text = $"Quotation sent to {name} at {email}.";
            }
        }
    }
}