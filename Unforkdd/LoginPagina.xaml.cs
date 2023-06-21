namespace Unforkdd;

public partial class LoginPagina : ContentPage
{
	public LoginPagina()
	{
		InitializeComponent();
	}
	private void OnLoginClicked(object sender, EventArgs e)
	{
		string username = UsernameEntry.Text;
		string password = PasswordEntry.Text;

		if (isValidCredentials(username, password)) 
		{
			DisplayAlert("Succes", "Login successful!", "OK");
		}
		else
		{
			DisplayAlert("Error", "Invalid username or password.", "OK");
		}
	}
	private void OnForgotPasswordClicked(object sender, EventArgs e)
	{
		DisplayAlert("Forogot Password", "Please contact support to reset your password", "OK");
	}
	private void OnRegisterClicked(object sender, EventArgs e)
	{
		DisplayAlert("Register", "Redirecting to registration page", "OK");
	}
	private bool isValidCredentials(string username, string password) 
	{
        // Test logica
		return (username == "admin" && password == "password");
    }
}