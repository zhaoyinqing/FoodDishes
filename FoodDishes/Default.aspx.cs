using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food;
namespace FoodDishes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList1.DataSource = BusinessLogic.ListFood();
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
                RadioButtonList1.DataSource = BusinessLogic.ListSize();
                RadioButtonList1.DataTextField = "Description";
                RadioButtonList1.DataValueField = "ID";
                RadioButtonList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            int foodID = Int32.Parse(DropDownList1.SelectedValue);
            string foodname = DropDownList1.SelectedItem.ToString();
            string size = RadioButtonList1.SelectedItem.ToString();

            string chilli = (CheckBox1.Checked ? "Y" : "N");
            string salt = (CheckBox2.Checked ? "Y" : "N");
            string pepper = (CheckBox3.Checked ? "Y" : "N");
            try
            {
                BusinessLogic.AddOrder(user, foodID, foodname, size, chilli, salt, pepper);
                Response.Redirect("Default2.aspx?username=" + user);
            }
            catch (Exception exp)
            {
                Response.Write(exp.ToString());
            }
        }
    }
}