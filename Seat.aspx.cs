using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Seat : System.Web.UI.Page
{
    int totalAmount;
    int selectedSeatsAmount;

    List<string> selectedButtonIDs;
    List<string> selectedSeats;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["selectedButtonIDs"] == null)
        {
            selectedButtonIDs = new List<string>();
            Session["selectedButtonIDs"] = selectedButtonIDs;
        }
        else
        {
            selectedButtonIDs = (List<string>)Session["selectedButtonIDs"];
        }

        lblTitle.Text = "The Baby Boss";
        lblDate.Text = "23.04.2017";
        lblCity.Text = "Istanbul";
        lblTheatre.Text = "Istinye Park Shopping Mall";
        lblSession.Text = "19:00";

        int adultAmount = 2;
        int studentAmount = 1;
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

        string seatName = (char)(65 + buttonRow) + "" + buttonNo;

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
        TEST.Text = "TEST: " + selectedButtonIDs.Count;
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
}