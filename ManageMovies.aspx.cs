using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageMovies : System.Web.UI.Page
{
    string userId, fullname;

    protected void Page_Load(object sender, EventArgs e)
    {
        userId = Request.QueryString["UID"];
        fullname = GetFullName(userId);

        if (lbMovies.Items.Count == 0)
        {
            LoadListBox();
            lbMovies.SelectedIndex = 0;
        }
    }
    

    protected void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(lbMovies.SelectedIndex == 0)
        {
            Clear();
        }
        else
        {
            string selectedMovie = lbMovies.SelectedItem.Text;
            int movieID = Int32.Parse(selectedMovie.Split('-')[0]);

            LoadMovie(movieID);
        }
    }

    private void Clear()
    {
        txtTitle.Text = "";
        txtIMDB.Text = "";
        txtDirector.Text = "";
        txtStars.Text = "";
        txtRuntime.Text = "";
        txtStoryline.Text = "";
        imgMovie.ImageUrl = txtPosterURL.Text = "";
    }

    void LoadListBox()
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * from movies";
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();

        lbMovies.Items.Add("New Movie");
        while (rdr.Read())
        {
            lbMovies.Items.Add(rdr["ID"].ToString() + " - " + rdr["movie_title"].ToString());

        }
        con.Close();
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
            txtTitle.Text = rdr["movie_title"].ToString();
            txtIMDB.Text = rdr["movie_rating"].ToString();
            txtDirector.Text = rdr["movie_director"].ToString();
            txtStars.Text = rdr["movie_stars"].ToString();
            txtRuntime.Text = rdr["movie_runtime"].ToString();
            txtStoryline.Text = rdr["movie_storyline"].ToString();
            imgMovie.ImageUrl = txtPosterURL.Text = rdr["movie_poster_url"].ToString();

        }
        con.Close();
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (lbMovies.SelectedIndex < 0)
            return;
        
        string title = txtTitle.Text.Replace("'", "''");
        string rating = txtIMDB.Text;
        string director = txtDirector.Text.Replace("'", "''");
        string stars = txtStars.Text.Replace("'", "''");
        string runtime = txtRuntime.Text;
        string storyline = txtStoryline.Text.Replace("'", "''");
        string poster_url = txtPosterURL.Text;

        if (poster_url.Contains("amazon") && poster_url.Contains("SY1000"))
            poster_url = IMDB_LinkResizer(poster_url); // "._V1_SY1000_CR0,0,631,1000_AL_" => "._V1_SY300_CR0,0,200,300_AL_"

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        OleDbCommand cmd;
        string query;

        if (lbMovies.SelectedIndex != 0)
        {
            string selectedMovie = lbMovies.SelectedItem.Text;
            int movieID = Int32.Parse(selectedMovie.Split('-')[0]);

            query = "UPDATE movies SET" + 
                " movie_title = '" + title + "'," + 
                " movie_rating = '" + rating + "'," +
                " movie_director = '" + director + "'," +
                " movie_stars = '" + stars + "'," +
                " movie_runtime = '" + runtime + "'," +
                " movie_storyline = '" + storyline + "'," +
                " movie_poster_url = '" + poster_url + "' " +
                " WHERE ID = " + movieID;
            cmd = new OleDbCommand(query, con);
        }
        else
        {
            query = "insert into movies (movie_title,movie_rating,movie_director,movie_stars,movie_runtime,movie_poster_url,movie_storyline) values (@title,@rating,@director,@stars,@runtime,@poster_url,@storyline)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@rating", rating);
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@stars", stars);
            cmd.Parameters.AddWithValue("@runtime", runtime);
            cmd.Parameters.AddWithValue("@poster_url", poster_url);
            cmd.Parameters.AddWithValue("@storyline", storyline);
        }

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        lbMovies.Items.Clear();
        LoadListBox();
        Clear();
        lbMovies.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
        lbMovies.SelectedIndex = 0;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lbMovies.SelectedIndex < 1)
            return;

        string selectedMovie = lbMovies.SelectedItem.Text;
        int movieID = Int32.Parse(selectedMovie.Split('-')[0]);

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "DELETE * FROM movies WHERE movies.ID = " + movieID;
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        lbMovies.Items.Clear();
        LoadListBox();
        Clear();
        lbMovies.SelectedIndex = 0;
    }

    string IMDB_LinkResizer(string url)
    {
        string body = url.Split('@')[0];
        string extra = url.Split('@')[1]; // "._V1_SY1000_CR0,0,947,1000_AL_.jpg" => "._V1_SY300_CRy,0,x,300_AL_.jpg"
        float x = Int32.Parse(extra.Split(',')[2]);

        if (x * 0.3 < 200)
            extra = "@._V1_SY300_CR0,0,200,300_AL_.jpg";
        else
        {
            int a = (int)(x * 0.3);
            int b = (a - 200) / 2;
            extra = "@._V1_SY300_CR" + b + ",0,200,300_AL_.jpg";
        }
        
        return body + extra;
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