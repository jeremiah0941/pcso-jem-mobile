using CommunityToolkit.Mvvm.Input;

namespace pcso_jem_mobile.ViewModel;

public partial class ProfileViewModel : BaseViewModel
{
    [ICommand]
    public void GoToLogin()
    {
        Shell.Current.GoToAsync("//Login");
    }
}