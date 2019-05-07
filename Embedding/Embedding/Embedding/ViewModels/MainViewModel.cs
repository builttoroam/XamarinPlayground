using MvvmHelpers;
using Xamarin.Forms;

namespace Embedding.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private LayoutOptions horizontalLayoutOptions = LayoutOptions.Center;
        private LayoutOptions verticalLayoutOptions = LayoutOptions.CenterAndExpand;

        public LayoutOptions HorizontalLayoutOptions
        {
            get => horizontalLayoutOptions;
            set => SetProperty(ref horizontalLayoutOptions, value);
        }

        public LayoutOptions VerticalLayoutOptions
        {
            get => verticalLayoutOptions;
            set => SetProperty(ref verticalLayoutOptions, value);
        }
    }
}