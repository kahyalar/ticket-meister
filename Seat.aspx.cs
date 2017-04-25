using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Seat : System.Web.UI.Page
{
    // TEST BLOCK
    string title;
    string date;
    string city;
    string theatre;
    string session;
    string totalPrice;
    string student, adult;
    string userId;

    string seatName;

    // TEST BLOCK

    int totalAmount;
    int selectedSeatsAmount;

    List<string> selectedButtonIDs;
    List<string> selectedSeats;

    protected void Page_Load(object sender, EventArgs e)
    {
        title = Request.QueryString["title"].ToString();
        date = Request.QueryString["date"].ToString();
        city = Request.QueryString["city"].ToString();
        theatre = Request.QueryString["theatre"].ToString();
        session = Request.QueryString["session"].ToString();
        totalPrice = Request.QueryString["price"].ToString();
        student = Request.QueryString["student"].ToString();
        adult = Request.QueryString["adult"].ToString();
        userId = Request.QueryString["UID"];
        // TEST BLOCK
        lblTitle.Text = title;
        lblCity.Text = city;
        lblTheatre.Text = theatre;
        lblDate.Text = date;
        lblSession.Text = session;
        lblAdultAmount.Text = adult;
        lblStudentAmount.Text = student;
        selectedSeatsAmount = Convert.ToInt32(student) + Convert.ToInt32(adult);
        // TEST BLOCK

        if (Session["selectedButtonIDs"] == null)
        {
            selectedButtonIDs = new List<string>();
            Session["selectedButtonIDs"] = selectedButtonIDs;
        }
        else
        {
            selectedButtonIDs = (List<string>)Session["selectedButtonIDs"];
        }

        int adultAmount = Convert.ToInt32(adult);
        int studentAmount = Convert.ToInt32(student);
        totalAmount = adultAmount + studentAmount;

        lblAdultAmount.Text = adultAmount + "";
        lblStudentAmount.Text = studentAmount + "";

        if (Session["selectedSeatsAmount"] == null)
        {
            selectedSeatsAmount = 0;
            Session["selectedSeatsAmount"] = selectedSeatsAmount;

            selectedSeats = new List<string>();
            Session["selectedSeats"] = selectedSeats;
        }
        else
        {
            selectedSeatsAmount = (int)Session["selectedSeatsAmount"];

            selectedSeats = (List<string>)Session["selectedSeats"];
        }

        lblSeatsSelected.Text = selectedSeatsAmount + " out of " + totalAmount + " Seat(s) Selected";


    }

    protected void SeatClicked(object sender, EventArgs e)
    {
        Button pressedButton = (Button)sender;
        string buttonID = pressedButton.ID;
        int buttonValue = Int32.Parse(buttonID.Substring(6));
        int buttonNo = (buttonValue - 2) % 30;
        int buttonRow = (buttonValue - 2) / 30;
        if (buttonNo == 0)
        {
            buttonNo = 30;
            buttonRow--;
        }

        seatName = (char)(65 + buttonRow) + "" + buttonNo;

        if (pressedButton.BackColor == ColorTranslator.FromHtml("#CCCCCC"))
        {
            selectedButtonIDs.Add(((Button)sender).ID);
            pressedButton.BackColor = Color.Yellow;
            selectedSeats.Add(seatName);
            selectedSeatsAmount++;

            if (selectedSeatsAmount == totalAmount)
            {
                AllSeatsEnabled(false);
                btnContinue.Enabled = true;
            }

            lblSeatsSelected.Text = selectedSeatsAmount + " out of " + totalAmount + " Seat(s) Selected";

            Session["selectedSeatsAmount"] = selectedSeatsAmount;
            Session["selectedSeats"] = selectedSeats;
            Session["selectedButtonIDs"] = selectedButtonIDs;
        }
        else
        {
            selectedButtonIDs.Remove(((Button)sender).ID);
            pressedButton.BackColor = ColorTranslator.FromHtml("#CCCCCC");
            selectedSeats.Remove(seatName);

            if (selectedSeatsAmount == totalAmount)
            {
                AllSeatsEnabled(true);
                btnContinue.Enabled = false;
            }

            selectedSeatsAmount--;

            lblSeatsSelected.Text = selectedSeatsAmount + " out of " + totalAmount + " Seat(s) Selected";

            Session["selectedSeatsAmount"] = selectedSeatsAmount;
            Session["selectedSeats"] = selectedSeats;
            Session["selectedButtonIDs"] = selectedButtonIDs;
        }
    }

    void AllSeatsEnabled(bool enable)
    {
        List<Button> availableSeats = new List<Button>();
        Button currentButton;
        for (int i = 3; i < 423; i++)
        {
            currentButton = (Button)FindControl("Button" + i);
            if (selectedButtonIDs.Exists(x => x == currentButton.ID))
                continue;
            else
                availableSeats.Add(currentButton);
        }
        foreach (Button button in availableSeats)
        {
            button.Enabled = enable;
        }
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        string seatNames = "";
        selectedSeats.Sort();
        for(int i = 0; i < selectedSeats.Count; i++)
        {
            if(i < selectedSeats.Count-1)
                seatNames = seatNames + selectedSeats[i].ToString() + ",";
            else
                seatNames = seatNames + selectedSeats[i].ToString();
        }
        Response.Redirect("Purchase.aspx?price=" + totalPrice + "&student=" + student + "&adult=" + adult + "&title=" + title + "&date=" + date + "&city=" + city + "&theatre=" + theatre + "&session=" + session + "&seats="+ seatNames + "&UID=" + userId);
    }
}