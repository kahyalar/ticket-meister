using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string surname = txtSurname.Text;
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        string city = ddlCity.SelectedItem.Text;
        string email = txtEmail.Text;
        string creditCard = txtCreditCard.Text;
        string expirationDate = txtExpDateMonth.Text + "/"+ txtExpDateYear.Text;
        string cvv = txtCVV.Text;


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("HermitDB.mdb") + ";Persist Security Info=False");
        string query = "insert into users (user_name,user_surname,user_username,user_password,user_city,user_email,user_card_no,user_exp_date,user_cvv) values (@name,@surname,@username,@password,@city,@email,@creditCard,@expirationDate,@cvv)";
        OleDbCommand cmd = new OleDbCommand(query, con);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@surname", surname);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@creditCard", creditCard);
        cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
        cmd.Parameters.AddWithValue("@cvv", cvv);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        clearFields();

        string registerInfo = "Register has been succesfully made, sir or ma'am!";
        Response.Redirect("Welcome.aspx?registerInfo=" + registerInfo);
    }

    private void clearFields()
    {
        txtName.Text = "";
        txtSurname.Text = "";
        txtUsername.Text = "";
        txtPassword.Text = "";
        ddlCity.SelectedIndex = 0;
        txtEmail.Text = "";
        txtCreditCard.Text = "";
        txtExpDateMonth.Text = "";
        txtExpDateYear.Text = "";
        txtCVV.Text = "";
    }
    
}