namespace Student_Management_App_1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (usernameEntry.Text == "user" && passwordEntry.Text == "1")
        {
            await Navigation.PushAsync(new MainTabbedPage());
        }
        else
        {
            await DisplayAlert("Error", "Invalid Login", "OK");
        }
    }
}