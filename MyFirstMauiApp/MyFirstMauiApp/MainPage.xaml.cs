namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }

    private void OnShowAppInfoButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.DisplayAlert("AppInfo",
            $"Version:{Environment.NewLine}{AppInfo.VersionString}" +
            $"{Environment.NewLine}{Environment.NewLine}" +
            $"Package name:{Environment.NewLine}{AppInfo.PackageName}",
            "OK");
    }
}

