using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Purchase : System.Web.UI.Page
{
    // TEST BLOCK
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
        lblName.Text = "Merve";
        lblSurname.Text = "Ariturk";
        lblCreditCardNumber.Text = "1234-5678-9012-3456";
        lblExpirationDate.Text = "07/19";
        lblCVV.Text = "123";
        lblTotalPrice.Text = "$32";
        // TEST BLOCK
    }
}