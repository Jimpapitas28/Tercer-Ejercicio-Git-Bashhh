using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SesionState
{
	public partial class SessionVariable2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
			ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
			txtProduct.Text = Session["strProduct"].ToString();
			txtDescription.Text = Session["strDescription"].ToString();
			txtImage.Text = Session["strImage"].ToString();
			Decimal decPrice = Convert.ToDecimal(Session["decPrice"]);
			txtPrice.Text = decPrice.ToString();
			txtNumberInStock.Text = Session["bytNumberInStock"].ToString();
			txtNumberOnOrder.Text = Session["bytNumberOnOrder"].ToString();
			txtReorderLevel.Text = Session["bytReordrLevel"].ToString();
			Byte byNumberInStock = Convert.ToByte(Session["byNumberInStock"]);
			Byte byNumberOnOrder = Convert.ToByte(Session["byNumberOnOrder"]);
			Decimal decValueInStock = decPrice * byNumberInStock;
			Decimal decValueOnOrder = decPrice * byNumberOnOrder;
			txtNumberInStock.Text = decValueInStock.ToString("c");
			txtNumberOnOrder.Text = decValueOnOrder.ToString("c");
		}
	}
}