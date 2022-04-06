using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ReactiveContentPage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}