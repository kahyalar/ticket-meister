using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    string userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
        lblFullName.Text = Request.QueryString["fullname"];
        userId = Request.QueryString["ID"];

        if (lblFullName.Text.Contains("BOSS"))
        {
            btnManage.Visible = true;
        }

        List<string> urls = new List<string>();
        List<string> ids = new List<string>();

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * from movies";
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        
        while (rdr.Read())
        {
            urls.Add(rdr["movie_poster_url"].ToString());
            ids.Add(rdr["ID"].ToString());

        }
        con.Close();

        ImageButton current;
        for (int i = 0; i < urls.Count; i++)
        {
            current = (ImageButton)FindControl("ImageButton" + (i + 1));
            if (current == null)
                continue;
            current.ImageUrl = urls[i];
            current.Visible = true;
            current.AlternateText = ids[i];
        }
    }


    protected void ImageButton_Click(object sender, ImageClickEventArgs e)
    {
        string id = ((ImageButton)sender).AlternateText;
        Response.Redirect("Movie.aspx?id=" + id + "&UID=" + userId);
    }

    protected void btnMyTickets_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyTickets.aspx?UID=" + userId);
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Welcome.aspx");
    }

    protected void btnManage_Click(object sender, EventArgs e)
    {
        Response.Redirect("ManageMovies.aspx?UID=" + userId);
    }
}