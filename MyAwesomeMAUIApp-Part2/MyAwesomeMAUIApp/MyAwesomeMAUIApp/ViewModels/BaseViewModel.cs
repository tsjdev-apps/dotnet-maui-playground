using CommunityToolkit.Mvvm.ComponentModel;

namespace MyAwesomeMAUIApp.ViewModels;

[INotifyPropertyChanged]
public partial class BaseViewModel
{
    [ObservableProperty]
    private bool _isLoading;
}
