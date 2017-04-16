using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ticket : System.Web.UI.Page
{// TEST BLOCK
    string title = "The Baby Boss";
    string date = "26/04/2017";
    string city = "Istanbul";
    string theatre = "Istinye Park Shopping Mall";
    string session = "19:00";
    string seats = "K14, K15, K16";
    string adult = "2";
    string student = "1";
    // TEST BLOCK

    protected void Page_Load(object sender, EventArgs e)
    {
        // TEST BLOCK
        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
        lblSession.Text = session;
        lblSeats.Text = seats;
        lblAdultAmount.Text = adult;
        lblStudentAmount.Text = student;
        lblTotalPrice.Text = "$32";
        lblBarcode.Text = "SEN3006-12345678";
        // TEST BLOCK
    }
}