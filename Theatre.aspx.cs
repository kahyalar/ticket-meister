using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Theatre : System.Web.UI.Page
{
    string title = "The Baby Boss";

    protected void Page_Load(object sender, EventArgs e)
    {
        lblTitle.Text = title;
    }
}