using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Theatre : System.Web.UI.Page
{
    string userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTitle.Text = Request.QueryString["title"];
        userId = Request.QueryString["UID"];
        if (ddlDate.Items.Count == 1)
            for (int i = 0; i < 14; i++)
            {
                ddlDate.Items.Add(DateTime.Today.AddDays(i).ToShortDateString());
            }
        if(ddlCity.Items.Count == 1)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
            string query = "select distinct theatre_city FROM theatres";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ddlCity.Items.Add(rdr["theatre_city"].ToString());
            }
            con.Close();
        }

        
    }

    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlCity.SelectedIndex == 0)
            return;
        ddlTheatre.Items.Clear();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * FROM theatres where theatre_city='"+ddlCity.SelectedItem.Text+"'";
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            ddlTheatre.Items.Add(rdr["theatre_name"].ToString());
        }
        con.Close();
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        if(ddlDate.SelectedIndex > 0 && ddlCity.SelectedIndex > 0)
        {
            string title = lblTitle.Text;
            string date = ddlDate.SelectedItem.Text;
            string city = ddlCity.SelectedItem.Text;
            string theatre = ddlTheatre.SelectedItem.Text;
            Response.Redirect("Session.aspx?title=" + title + "&date=" + date + "&city=" + city + "&theatre=" + theatre + "&UID=" + userId);
        }
    }
}