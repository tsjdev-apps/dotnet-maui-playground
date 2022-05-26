using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyAwesomeMAUIApp.Resources.Strings;
using MyAwesomeMAUIApp.Services;

namespace MyAwesomeMAUIApp.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    private readonly IAppInfo _appInfo;
    private readonly IDialogService _dialogService;

    [ObservableProperty]
    private string _appName;

    [ObservableProperty]
    private string _appVersion;

    public MainPageViewModel(IAppInfo appInfo, IDialogService dialogService)
    {
        _appInfo = appInfo;
        _dialogService = dialogService;
    }

    [ICommand]
    private void LoadData()
    {
        AppName = _appInfo.Name;
        AppVersion = _appInfo.VersionString;
    }

    [ICommand]
    private async Task ShowAppInfoAsync()
    {
        await _dialogService.ShowAsync(AppResources.MainPageViewModelAppInfoDialogTitle,
            string.Format(AppResources.MainPageViewModelAppInfoDialogMessage, AppName, AppVersion));
    }
}
