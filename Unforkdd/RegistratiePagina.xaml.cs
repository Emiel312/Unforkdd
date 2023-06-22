namespace Unforkdd;

public partial class RegistratiePagina : ContentPage
{
	public RegistratiePagina()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string username = Username.Text;
        string passwordfirst = ChoosPasswordEntry.Text;
        string passwordsecond = ChoosPasswordEntrySecond.Text;


        if (username != null && passwordfirst != null && passwordsecond != null && passwordfirst == passwordsecond)
        {
            DisplayAlert("Note", "Your registration was successful.", "OK");
            Navigation.PushAsync(new LoginPagina());
        }
        else
        {
            DisplayAlert("Error", "Invalid username or password(s).", "OK");
        }
    }
}