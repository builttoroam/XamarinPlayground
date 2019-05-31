using System;
using System.Diagnostics;
using Linker.Utilities;

namespace Linker
{
    public partial class MainPage
    {
        private const string EnglishAlphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var stringUtilities = Activator.CreateInstance<StringUtilities>();
            var reversedAlphabet = stringUtilities.ReverseString(EnglishAlphabet);

            Debug.WriteLine(reversedAlphabet);
        }
    }
}
