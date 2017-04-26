using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session : System.Web.UI.Page
{
    string title;
    string date;
    string city;
    string theatre;
    string userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        title = Request.QueryString["title"];
        date = Request.QueryString["date"];
        city = Request.QueryString["city"];
        theatre = Request.QueryString["theatre"];
        userId = Request.QueryString["UID"];
        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
    }

    protected void btnBack0_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex >= 0)
            Response.Redirect("TicketAmount.aspx?session=" + RadioButtonList1.SelectedItem.Text + "&title=" + title + "&date=" + date + "&city=" + city + "&theatre=" + theatre + "&UID=" + userId);
    }
}