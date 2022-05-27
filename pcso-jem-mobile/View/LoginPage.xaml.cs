using pcso_jem_mobile.ViewModel;


namespace pcso_jem_mobile.View;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        // instead of doing new LoginViewModel
        // I can resolve it in constructor because I did register
        BindingContext = loginViewModel;
    }
}