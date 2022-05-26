namespace MyAwesomeMAUIApp.Services
{
    public interface IDialogService
    {
        Task ShowAsync(string title, string message);
    }
}