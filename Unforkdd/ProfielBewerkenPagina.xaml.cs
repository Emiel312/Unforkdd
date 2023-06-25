namespace Unforkdd;

public partial class ProfielBewerkenPagina : ContentPage
{
	public ProfielBewerkenPagina()
	{
		InitializeComponent();
	}

    private void AddImage_Clicked(object sender, EventArgs e)
    {
        //string imageUrl = "http://voorbeeld.com/image.jpg";
        //Navigation.PushAsync(new ImagePage(imageUrl));
    }
    private void UpdateClicked(object sender, EventArgs e)
    {
        //wijzigen van gegeven
        string Voornaam = (string)sender;
        string Achtermaan = (string)sender;

        if (string.IsNullOrEmpty(Voornaam) || string.IsNullOrEmpty(Achtermaan))
        {
            DisplayAlert("Foutmelding", "Vul alle vereiste velden in", "OK");

        }
    }

    private void DeleteClicked(object sender, EventArgs e)
    {
        //gegevens verwijderen

    }

    private void ReturnToImage_Clicked(object sender, EventArgs e)
    {
        //terugkeren naar afbeelding
    }

    private void SaveProfile_Clicked(object sender, EventArgs e)
    {
        //profiel opslaan
    }
    private void Update_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
    private void Delete_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
    private void Validate_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
    private void GoToProfilePage_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
    private void RetrieveData_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
    private void SaveData_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
    private void DeleteData_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
}