using MyAwesomeMAUIApp.Resources.Strings;

namespace MyAwesomeMAUIApp.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowAsync(string title, string message)
        {
            await Application.Current.MainPage?
                .DisplayAlert(title, message, AppResources.DialogOkLabel);
        }
    }
}
