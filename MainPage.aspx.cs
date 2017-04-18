using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> urls = new List<string>();

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * from movies";
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        
        while (rdr.Read())
        {
            urls.Add(rdr["movie_poster_url"].ToString());

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
        }
    }

}