using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFKidzeeZone.Models;
using XFKidzeeZone.ViewModels;

namespace XFKidzeeZone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        const uint DURATION_ANIMATION_IMAGE = 250;
        const uint DURATION_ANIMATION = 500;

        public DetailPage(Game popular)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, popular);
            imageGame.TranslationX = -1200;
            lbCompany.TranslationX = -1300;
            lbName.TranslationX = -1300;
        }

        protected override async void OnAppearing()
        {
            await imageGame.TranslateTo(-1200, 0, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.FadeTo(0.5, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.TranslateTo(-600, 0, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.TranslateTo(0, 0, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.FadeTo(1, DURATION_ANIMATION_IMAGE, Easing.Linear);

            await Task.WhenAll(
              lbCompany.TranslateTo(-1300, 0, DURATION_ANIMATION, Easing.Linear),
              lbCompany.TranslateTo(-650, 0, DURATION_ANIMATION, Easing.Linear),
              lbCompany.TranslateTo(0, 0, DURATION_ANIMATION, Easing.Linear),
              lbName.TranslateTo(-1300, 0, DURATION_ANIMATION, Easing.Linear),
              lbName.TranslateTo(-650, 0, DURATION_ANIMATION, Easing.Linear),
              lbName.TranslateTo(0, 0, DURATION_ANIMATION, Easing.Linear)
          );
        }
    }
}