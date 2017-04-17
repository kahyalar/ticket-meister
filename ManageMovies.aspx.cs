using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageMovies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(lbMovies.Items.Count == 0)
            LoadListBox();
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
        imgMovie.ImageUrl = "";
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
            txtIMDB.Text = rdr["movie_imdb_link"].ToString();
            txtDirector.Text = rdr["movie_director"].ToString();
            txtStars.Text = rdr["movie_stars"].ToString();
            txtRuntime.Text = rdr["movie_runtime"].ToString();
            txtStoryline.Text = rdr["movie_storyline"].ToString();
            imgMovie.ImageUrl = rdr["movie_poster_url"].ToString();

        }
        con.Close();
    }
    
}