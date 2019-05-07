using System;
using System.ComponentModel;
using Embedding.ViewModels;
using Xamarin.Forms;

namespace Embedding
{
    // NOTE: The XAML compilation needs to be off for pages that use native controls on them,
    //       as per documentation https://docs.microsoft.com/en-us/xamarin/xamarin-forms/platform/native-views/xaml
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private MainViewModel ViewModel => BindingContext as MainViewModel;

        private void HandleNativeViewAlignmentChange(object sender, EventArgs e)
        {
            if (ViewModel == null)
            {
                return;
            }

            ViewModel.HorizontalLayoutOptions = ViewModel.HorizontalLayoutOptions.Equals(LayoutOptions.Center) ? LayoutOptions.Fill : LayoutOptions.Center;
            ViewModel.VerticalLayoutOptions = ViewModel.VerticalLayoutOptions.Equals(LayoutOptions.CenterAndExpand) ? LayoutOptions.EndAndExpand : LayoutOptions.CenterAndExpand;
        }
    }
}