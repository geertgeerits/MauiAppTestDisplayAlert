namespace MauiAppTestDisplayAlert;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        ShowLicense();
    }

    private async void ShowLicense()
    {
        bool bAnswer = await Application.Current.MainPage.DisplayAlert("License", "Blablabla", "Yes", "No");

        //if (bAnswer)
        //{
        //    Preferences.Default.Set("SettingLicense", true);
        //}
        //else
        //{
        //    Application.Current.Quit();
        //}
    }
}

