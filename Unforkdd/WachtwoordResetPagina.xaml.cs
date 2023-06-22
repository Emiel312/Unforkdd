namespace Unforkdd;

public partial class WachtwoordResetPagina : ContentPage
{
	public WachtwoordResetPagina()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string username = Username.Text;

        if (username != null)
        {
            DisplayAlert("Note", "The administrator will contact you soon.", "OK");
            Navigation.PushAsync(new LoginPagina());
        }
        else
        {
            DisplayAlert("Error", "Invalid username", "OK");
        }
        

    }
}