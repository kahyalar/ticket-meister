using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Purchase : System.Web.UI.Page
{
    // TEST BLOCK
    string title;
    string date;
    string city;
    string theatre;
    string session;
    string seats;
    string adult;
    string student;
    string name;
    string surname;
    string creditCard;
    string expDate;
    string cvv;
    string totalPrice;
    // TEST BLOCK
    string userId;

    protected void Page_Load(object sender, EventArgs e)
    {
        title = Request.QueryString["title"];
        date = Request.QueryString["date"];
        city = Request.QueryString["city"];
        theatre = Request.QueryString["theatre"];
        session = Request.QueryString["session"];
        seats = Request.QueryString["seats"];
        adult = Request.QueryString["adult"];
        student = Request.QueryString["student"];
        totalPrice = Request.QueryString["price"];
        userId = Request.QueryString["UID"];

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * from users where ID="+userId;
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        rdr.Read();
        name = rdr["user_name"].ToString();
        surname = rdr["user_surname"].ToString();
        creditCard = rdr["user_card_no"].ToString();
        expDate = rdr["user_exp_date"].ToString();
        cvv = rdr["user_cvv"].ToString();
        con.Close();
        string lastFour = creditCard.Substring(12);
        
        // TEST BLOCK
        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
        lblSession.Text = session;
        lblSeats.Text = seats;
        lblAdultAmount.Text = adult;
        lblStudentAmount.Text = student;
        lblName.Text = name;
        lblSurname.Text = surname;
        lblCreditCardNumber.Text = "Credit card ending in "+ lastFour;
        lblExpirationDate.Text = "Expiration Date: "+expDate;
        lblCVV.Text = "CVV: "+cvv;
        lblTotalPrice.Text = "$"+totalPrice;
        // TEST BLOCK
    }

    protected void btnPurchase_Click(object sender, EventArgs e)
    {
        string info = "true";
        Response.Redirect("Ticket.aspx?price=" + totalPrice + "&student=" + student + "&adult=" + adult + "&title=" + title + "&date=" + date + "&city=" + city + "&theatre=" + theatre + "&session=" + session + "&seats=" + seats + "&UID=" + userId + "&info=" + info);
    }
}