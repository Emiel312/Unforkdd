namespace Unforkdd;

public partial class ProfielPagina : ContentPage
{
	public ProfielPagina()
	{
		InitializeComponent();
	}

    private void ViewImage_Clicked(object sender, EventArgs e)
    {
        //doorlinken naar afbeeldingpagina
    }

    private void BewerkenButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfielBewerkenPagina());
    }

    private void RetrieveData_Clicked(object sender, EventArgs e)
    {
        //ophalen van gegevens uit DB
    }

    private void RetrievePhotos_Clicked(object sender, EventArgs e)
    {
        //ophalen van afbeeldingen uit de opslag
    }
    private void Update_Clicked(object sender, EventArgs e) 
    {
        //implementeer logica
    }
    private void SaveButton_Clicked(object sender, EventArgs e) 
    {
        //implementeer logica
    }
    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        //implementeer logica
    }
}