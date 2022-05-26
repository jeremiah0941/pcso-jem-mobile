using CommunityToolkit.Mvvm.ComponentModel;

namespace pcso_jem_mobile.ViewModel;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;
}