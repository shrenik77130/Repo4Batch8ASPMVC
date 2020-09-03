using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class billing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LProdname.Text = "Product Name : " + Session["prodname"];
        LPrice.Text = "Price : Rs." + Session["price"];
        LQtys.Text = "Qtys :" + Session["qtys"];

        float price = float.Parse(Session["price"]+"");
        int qtys = int.Parse(Session["qtys"]+"");
        float tax = float.Parse(LTaxrate.Text);

        float total = (price + (price * tax / 100)) * qtys;
        Ltotal.Text = "Total Amount = Rs." + total;
    }
}