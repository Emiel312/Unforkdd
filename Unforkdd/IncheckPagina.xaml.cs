namespace Unforkdd;

public partial class IncheckPagina : ContentPage
{
	public IncheckPagina()
	{
		InitializeComponent();
	}
    private async void OnAddImageClicked(object sender, EventArgs e)
    {
        var result = await MediaPicker.PickPhotoAsync();


        /*
        if (result != null)
        {
            selectedImageStream = await result.OpenReadAsync();
        }
        */
    }



    private async void OnCheckInClicked(object sender, EventArgs e)
    {
        string title = TitleEntry.Text;
        string restaurant = RestaurantEntry.Text;
        string description = DescriptionEntry.Text;
        double rating = RatingSlider.Value;



        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(restaurant))
        {
            await DisplayAlert("Error", "Please enter a title and a restaurant.", "OK");
            return;
        }


        /*
        if (selectedImageStream == null)
        {
            await DisplayAlert("Error", "Please select an image.", "OK");
            return;
        }
        */



        // Perform the check-in logic here
        // You can save the image stream, title, restaurant, description, and rating to a database or perform any other required operations



        // Reset the page
        ResetPage();



        await DisplayAlert("Success", "Dish checked-in successfully!", "OK");
    }



    private void ResetPage()
    {
        TitleEntry.Text = string.Empty;
        RestaurantEntry.Text = string.Empty;
        DescriptionEntry.Text = string.Empty;
        RatingSlider.Value = 5;
        // selectedImageStream = null;
    }
}