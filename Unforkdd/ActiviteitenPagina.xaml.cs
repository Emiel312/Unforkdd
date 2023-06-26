namespace Unforkdd;

public partial class ActiviteitenPagina : ContentPage
{
	public ActiviteitenPagina()
	{
		InitializeComponent();

        // Add placeholder activities to the ScrollView
        AddActivities();
    }
    private void AddActivities()
    {
        // Dynamically add activities to the StackLayout within the ScrollView
        for (int i = 1; i <= 20; i++)
        {
            var activityLabel = new Label
            {
                Text = $"Activity {i}",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };



            // Add the activity label to the StackLayout
            activitiesStackLayout.Children.Add(activityLabel);
        }
    }



    private void OnCheckInClicked(object sender, EventArgs e)
    {
        // Implement your logic for the "Check-In" button click
        Navigation.PushAsync(new IncheckPagina());
    }



    private void OnFollowersClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VolgersPagina());
    }

    private void OnGroepenClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GroepenPagina());
    }



    private void OnHomeClicked(object sender, EventArgs e)
    {
        // Implement your logic for the "Home" button click
        DisplayAlert("Home", "Navigate to home page logic here.", "OK");
    }



    private void OnProfileClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfielPagina());
    }



    private void OnRestaurantClicked(object sender, EventArgs e)
    {
        // Implement your logic for the "Restaurant" button click
        DisplayAlert("Restaurant", "Navigate to restaurant page logic here.", "OK");
    }

}