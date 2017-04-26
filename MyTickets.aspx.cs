using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyTickets : System.Web.UI.Page
{
    string title, date, city, theatre, session, adult, student, seats, price, pnr, barcode;
    string userId, fullname;

    protected void Page_Load(object sender, EventArgs e)
    {
        userId = Request.QueryString["UID"].ToString();
        fullname = GetFullName(userId);

        if (lstTickets.Items.Count == 0)
        {
            LoadListBox(userId);
        }
        
    }

    void LoadListBox(string UID)
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * FROM tickets where UID=" + userId;
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        int count = 0;
        while (rdr.Read())
        {
            Session["title"] = rdr["ticket_title"].ToString();
            Session["date"] = rdr["ticket_date"].ToString();
            Session["city"] = rdr["ticket_city"].ToString();
            Session["seats"] = rdr["ticket_seats"].ToString();
            Session["theatre"] = rdr["ticket_theatre"].ToString();
            Session["session"] = rdr["ticket_session"].ToString();
            Session["adult"] = rdr["ticket_adult"].ToString();
            Session["student"] = rdr["ticket_student"].ToString();
            Session["price"] = rdr["ticket_price"].ToString();
            Session["pnr"] = rdr["ticket_pnr"].ToString();
            Session["barcode"] = rdr["ticket_barcode"].ToString();
            title = Session["title"].ToString();
            date = Session["date"].ToString();
            pnr = Session["pnr"].ToString();
            lstTickets.Items.Add("PNR: " + pnr + " | Movie Title: " + title + " | Date: " + date);
            count++;
        }
        con.Close();

        if (count == 0)
            lstTickets.Items.Add("Found nothing !");
    }

    void UpdateSessionVariables()
    {

    }

    protected void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstTickets.Items[0].ToString() != "Found nothing !")
        {
            string currentPNR = lstTickets.SelectedItem.Text;
            currentPNR = currentPNR.Substring(5, 8);

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
            string query = "select * FROM tickets where ticket_pnr= '" + currentPNR + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Session["title"] = rdr["ticket_title"].ToString();
            Session["date"] = rdr["ticket_date"].ToString();
            Session["city"] = rdr["ticket_city"].ToString();
            Session["seats"] = rdr["ticket_seats"].ToString();
            Session["theatre"] = rdr["ticket_theatre"].ToString();
            Session["session"] = rdr["ticket_session"].ToString();
            Session["adult"] = rdr["ticket_adult"].ToString();
            Session["student"] = rdr["ticket_student"].ToString();
            Session["price"] = rdr["ticket_price"].ToString();
            Session["pnr"] = rdr["ticket_pnr"].ToString();
            Session["barcode"] = rdr["ticket_barcode"].ToString();
            con.Close();

            btnShowTicket.Enabled = true;
        }
    }

    protected void btnShowTicket_Click(object sender, EventArgs e)
    {
        price = Session["price"].ToString();
        student = Session["student"].ToString();
        adult = Session["adult"].ToString();
        title = Session["title"].ToString();
        date = Session["date"].ToString();
        city = Session["city"].ToString();
        theatre = Session["theatre"].ToString();
        session = Session["session"].ToString();
        seats = Session["seats"].ToString();
        pnr = Session["pnr"].ToString();
        barcode = Session["barcode"].ToString();
        string info = "false";
        Response.Redirect("Ticket.aspx?price=" + price + "&student=" + student + "&adult=" + adult + "&title=" + title + "&date=" + date + "&city=" + city + "&theatre=" + theatre + "&session=" + session + "&seats=" + seats + "&UID=" + userId + "&info=" + info + "&pnr=" + pnr + "&barcode=" + barcode);
    }

    string GetFullName(string userId)
    {
        string _fullname;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * from users where ID = " + userId;
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        rdr.Read();
        _fullname = rdr["user_name"].ToString() + " " + rdr["user_surname"].ToString();
        con.Close();

        return _fullname;
    }

    protected void btnReturnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx?ID=" + userId + "&fullname=" + fullname);
    }
}