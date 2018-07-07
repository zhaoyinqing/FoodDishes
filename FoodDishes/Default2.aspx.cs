using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food;
namespace FoodDishes
{
    using Food;
    public partial class Default2 : System.Web.UI.Page
    {
        string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["username"];
            if (!IsPostBack)
            {
                BindGrid();
            }
         }
        private void BindGrid()
        {
            //GridView1.DataSource = BusinessLogic.ListOrderBy(name);
            //GridView1.DataBind();
            DataList1.DataSource = BusinessLogic.ListOrderBy(name);
            DataList1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int orderId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            BusinessLogic.DeleteOrder(orderId);
            BindGrid();
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int orderId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            int foodid = Int32.Parse((row.FindControl("DropDownList1") as DropDownList).SelectedValue);
            string size = (row.FindControl("TextBox1") as TextBox).Text;
            string chilli = (row.FindControl("TextBox2") as TextBox).Text;
            string salt = (row.FindControl("TextBox3") as TextBox).Text;
            string pepper = (row.FindControl("TextBox4") as TextBox).Text;
            BusinessLogic.UpdateOrder(orderId, foodid,size, chilli, salt, pepper);          
            GridView1.EditIndex = -1;
            BindGrid();
        }
            


        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderId = (int)GridView1.SelectedDataKey.Value;
            using (ShopOrders entities = new ShopOrders())
            {
                Order order = entities.Orders.Where(p => p.OrderID == orderId).First<Order>();
                //DetailsView1.DataSource = new Order[] { order };
                //DetailsView1.DataBind();
                GridView1.DataSource = new Order[] { order };
                GridView1.DataBind();
            }
        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGrid();
        }
       
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow &&
                (e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                Order order = (Order)e.Row.DataItem;
                DropDownList dp = (DropDownList)e.Row.FindControl("DropDownList1");
                if (dp != null)
                {
                    dp.DataSource = BusinessLogic.ListFood();
                    dp.DataTextField = "Name";
                    dp.DataValueField = "ID";
                    dp.DataBind();
                    dp.SelectedValue = order.FoodID.ToString();
                }
            }
        }
        protected void Pick_Command(Object sender, DataListCommandEventArgs e)
        {
            string cmd = e.CommandName;
            string foodID = e.CommandArgument.ToString();
            int index = e.Item.ItemIndex;
            Label lab = (Label)DataList1.Items[index].FindControl("Label8");
            DataStatus.Text = String.Format("{0}/{1}/{2}/{3}",
                cmd,
                foodID,
                index,
                lab.Text);
        }
    }
}