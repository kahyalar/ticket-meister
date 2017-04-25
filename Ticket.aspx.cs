using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ticket : System.Web.UI.Page
{
    string title;
    string date;
    string city;
    string theatre;
    string session;
    string seats;
    string adult;
    string student;
    string totalPrice;
    string userId;
    string info;

    protected void Page_Load(object sender, EventArgs e)
    {
        info = Request.QueryString["info"];
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

        if (info.Equals("true"))
        {
            Random rd = new Random();
            int pnr = rd.Next(10000000, 99999999);
            lblPNR.Text = "PNR: " + pnr.ToString();
            string barcode = "SEN3006-" + pnr;
            lblBarcode.Text = barcode;

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
            string query = "INSERT INTO tickets ( UID, ticket_title, ticket_date, ticket_city, ticket_theatre, ticket_session, ticket_adult, ticket_student, ticket_seats, ticket_price, ticket_pnr, ticket_barcode ) values ( @UID, @ticket_title, @ticket_date, @ticket_city, @ticket_theatre, @ticket_session, @ticket_adult, @ticket_student, @ticket_seats, @ticket_price, @ticket_pnr, @ticket_barcode ) ";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@UID", userId);
            cmd.Parameters.AddWithValue("@ticket_title", title);
            cmd.Parameters.AddWithValue("@ticket_date", date);
            cmd.Parameters.AddWithValue("@ticket_city", city);
            cmd.Parameters.AddWithValue("@ticket_theatre", theatre);
            cmd.Parameters.AddWithValue("@ticket_session", session);
            cmd.Parameters.AddWithValue("@ticket_adult", adult);
            cmd.Parameters.AddWithValue("@ticket_student", student);
            cmd.Parameters.AddWithValue("@ticket_seats", seats);
            cmd.Parameters.AddWithValue("@ticket_price", totalPrice);
            cmd.Parameters.AddWithValue("@ticket_pnr", pnr);
            cmd.Parameters.AddWithValue("@ticket_barcode", barcode);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            lblPNR.Text = "PNR: " + Request.QueryString["pnr"];
            lblBarcode.Text = Request.QueryString["barcode"];
        }

        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
        lblSession.Text = "Session: " + session;
        lblSeats.Text = seats;
        lblAdultAmount.Text = adult;
        lblStudentAmount.Text = student;
        lblTotalPrice.Text = "Price: $" + totalPrice;
    }
}