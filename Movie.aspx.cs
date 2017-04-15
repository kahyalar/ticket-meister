using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Movie : System.Web.UI.Page
{
    string imageURL = "~/movies/236019314.jpg";
    string title = "The Baby Boss";
    string rating = "6.5";
    string director = "Tom McGrath";
    string stars = "Alec Baldwin<br/>Steve Buscemi<br/>Jimmy Kimmel";
    string runtime = "97";
    string storyline = "A new baby's arrival impacts a family, told from the point of view of a delightfully unreliable narrator -- a wildly imaginative 7-year-old named Tim. The most unusual Boss Baby (Alec Baldwin) arrives at Tim's home in a taxi, wearing a suit and carrying a briefcase. The instant sibling rivalry must soon be put aside when Tim discovers that Boss Baby is actually a spy on a secret mission, and only he can help thwart a dastardly plot that involves an epic battle between puppies and babies.";

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnTest_Click(object sender, EventArgs e)
    {
        LoadMovie(0);
    }

    void LoadMovie(int movieID)
    {
        imgMovie.ImageUrl = imageURL;
        lblTitle.Text = title;
        lblRating.Text = "IMDB: " + rating + "/10";
        lblDirector.Text = director;
        lblStars.Text = stars;
        lblRuntime.Text = runtime + " min";
        lblStoryline.Text = storyline;
    }
}