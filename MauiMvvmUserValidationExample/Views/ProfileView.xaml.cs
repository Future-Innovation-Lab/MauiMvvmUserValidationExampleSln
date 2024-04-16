using MauiMvvmUserValidationExample.ViewModels;

namespace MauiMvvmUserValidationExample
{
    public partial class ProfileView : ContentPage
    {
        public ProfileView(ProfileViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }

        
    }

}
