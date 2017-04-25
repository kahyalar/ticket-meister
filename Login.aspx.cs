using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "select * FROM users where user_username='"+username+"' AND user_password='"+password+"'";
        OleDbCommand cmd = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader rdr = cmd.ExecuteReader();
        if (!rdr.Read())
            lblMessage.Text = "Please check your credientals";
        else
        {
            string fullname = rdr["user_name"].ToString() +" "+ rdr["user_surname"].ToString();
            string userId = rdr["ID"].ToString();
            Response.Redirect("MainPage.aspx?fullname=" + fullname + "&ID="+userId);
        }
        con.Close();
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        
    }
}