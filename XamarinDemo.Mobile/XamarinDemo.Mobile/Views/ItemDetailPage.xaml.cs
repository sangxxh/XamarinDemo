using System.ComponentModel;
using Xamarin.Forms;
using XamarinDemo.Mobile.ViewModels;

namespace XamarinDemo.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}