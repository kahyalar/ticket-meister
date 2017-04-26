using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TicketAmount : System.Web.UI.Page
{
    string title;
    string date;
    string city;
    string theatre;
    string session;
    string userId;

    int totalPrice;

    int adultAmount, adultPrice;
    int adultMultiplier = 12;

    int studentAmount, studentPrice;
    int studentMultiplier = 8;

    string dolarSign = "$";

    protected void Page_Load(object sender, EventArgs e)
    {
        userId = Request.QueryString["UID"];
        if (Session["adultAmount"] == null)
        {
            adultAmount = 0;
            Session["adultAmount"] = adultAmount;
            lblAdultAmount.Text = adultAmount.ToString();
            adultPrice = 0;
            Session["adultPrice"] = adultPrice;
            lblAdultTotalPrice.Text = dolarSign + adultPrice;
        }
        else
        {
            adultAmount = (int)Session["adultAmount"];
            adultPrice = adultAmount * adultMultiplier;
            lblAdultAmount.Text = adultAmount.ToString();
            lblAdultTotalPrice.Text = dolarSign + adultPrice;
        }

        if (Session["studentAmount"] == null)
        {
            studentAmount = 0;
            Session["studentAmount"] = studentAmount;
            lblStudentAmount.Text = studentAmount.ToString();
            studentPrice = 0;
            Session["studentPrice"] = studentPrice;
            lblStudentTotalPrice.Text = dolarSign + studentPrice;
        }
        else
        {
            studentAmount = (int)Session["studentAmount"];
            studentPrice = studentAmount * studentMultiplier;
            lblStudentAmount.Text = studentAmount.ToString();
            lblStudentTotalPrice.Text = dolarSign + studentPrice;
        }


        title = Request.QueryString["title"].ToString();
        date = Request.QueryString["date"].ToString();
        city = Request.QueryString["city"].ToString();
        theatre = Request.QueryString["theatre"].ToString();
        session = Request.QueryString["session"].ToString();

        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
        lblSession.Text = session;
    }

    protected void btnAdultInc_Click(object sender, EventArgs e)
    {
        adultAmount++;
        lblAdultAmount.Text = adultAmount.ToString();
        adultPrice = adultAmount * adultMultiplier;
        Session["adultPrice"] = adultPrice;
        Session["adultAmount"] = adultAmount;
        lblAdultTotalPrice.Text = dolarSign + adultPrice;
        Session["totalPrice"] = adultPrice + (int)Session["studentPrice"];
        lblTotalPrice.Text = dolarSign + Session["totalPrice"].ToString();
        enableDisable();
    }

    protected void btnStudentInc_Click(object sender, EventArgs e)
    {
        studentAmount++;
        lblStudentAmount.Text = studentAmount.ToString();
        studentPrice = studentAmount * studentMultiplier;
        Session["studentPrice"] = studentPrice;
        Session["studentAmount"] = studentAmount;
        lblStudentTotalPrice.Text = dolarSign + studentPrice;
        Session["totalPrice"] = studentPrice + (int)Session["adultPrice"];
        lblTotalPrice.Text = dolarSign + Session["totalPrice"].ToString();
        enableDisable();
    }

    protected void btnAdultDec_Click(object sender, EventArgs e)
    {
        if (lblAdultAmount.Text != "0")
        {
            adultAmount--;
            lblAdultAmount.Text = adultAmount.ToString();
            adultPrice = adultAmount * adultMultiplier;
            Session["adultPrice"] = adultPrice;
            Session["adultAmount"] = adultAmount;
            lblAdultTotalPrice.Text = dolarSign + adultPrice;
            Session["totalPrice"] = adultPrice + (int)Session["studentPrice"];
            lblTotalPrice.Text = dolarSign + Session["totalPrice"].ToString();
        }
        enableDisable();
    }

    protected void btnStudentDec_Click(object sender, EventArgs e)
    {
        if (lblStudentAmount.Text != "0")
        {
            studentAmount--;
            lblStudentAmount.Text = studentAmount.ToString();
            studentPrice = studentAmount * studentMultiplier;
            Session["studentPrice"] = studentPrice;
            Session["studentAmount"] = studentAmount;
            lblStudentTotalPrice.Text = dolarSign + studentPrice;
            Session["totalPrice"] = studentPrice + (int)Session["adultPrice"];
            lblTotalPrice.Text = dolarSign + Session["totalPrice"].ToString();
        }
        enableDisable();

    }

    public void enableDisable()
    {
        if (lblAdultAmount.Text == "0")
            btnAdultDec.Enabled = false;
        else
            btnAdultDec.Enabled = true;

        if (lblStudentAmount.Text == "0")
            btnStudentDec.Enabled = false;
        else
            btnStudentDec.Enabled = true;
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        string totalPrice = lblTotalPrice.Text.Remove(0, 1);
        string student = lblStudentAmount.Text;
        string adult = lblAdultAmount.Text;
        int total = Int32.Parse(lblAdultAmount.Text) + Int32.Parse(lblStudentAmount.Text);

        if (total > 0)
            Response.Redirect("Seat.aspx?price=" + totalPrice + "&student=" + student + "&adult=" + adult + "&title=" + title + "&date=" + date + "&city=" + city + "&theatre=" + theatre + "&session=" + session + "&UID=" + userId);
    }
}