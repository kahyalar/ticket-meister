using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session : System.Web.UI.Page
{
    string title = "The Baby Boss";
    string date = "26/04/2017";
    string city = "Istanbul";
    string theatre = "Istinye Park Shopping Mall";

    protected void Page_Load(object sender, EventArgs e)
    {
        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
    }
}