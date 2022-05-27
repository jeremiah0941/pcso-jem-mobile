using pcso_jem_mobile.ViewModel;

namespace pcso_jem_mobile.View;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }
}