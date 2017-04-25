using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Movie : System.Web.UI.Page
{
    string userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        userId = Request.QueryString["UID"];
        int id = Int32.Parse(Request.QueryString["id"]);

        LoadMovie(id);
    }

    void LoadMovie(int ID)
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * from movies where ID = " + ID;
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();

        if (rdr.Read())
        {
            lblTitle.Text = rdr["movie_title"].ToString();
            lblDirector.Text = rdr["movie_director"].ToString();
            lblStars.Text = rdr["movie_stars"].ToString().Replace(",","<br/>");
            lblRating.Text = "IMDB: " + rdr["movie_rating"] + "/10";
            lblRuntime.Text = rdr["movie_runtime"].ToString() + " min";
            lblStoryline.Text = rdr["movie_storyline"].ToString();
            imgMovie.ImageUrl = rdr["movie_poster_url"].ToString();

        }
        con.Close();
    }

    protected void btnBuy_Click(object sender, EventArgs e)
    {
        Response.Redirect("Theatre.aspx?title=" + lblTitle.Text + "&UID=" + userId);
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx?");
    }
}