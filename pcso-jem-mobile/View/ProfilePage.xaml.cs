using pcso_jem_mobile.ViewModel;

namespace pcso_jem_mobile.View;

public partial class ProfilePage : ContentPage
{
    public ProfilePage(ProfileViewModel profileViewModel)
    {
        InitializeComponent();
        BindingContext = profileViewModel;
    }
}