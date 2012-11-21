using System;
using Windows.UI.Xaml;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WinRTExceptions.Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StandardButtonClick(object sender, RoutedEventArgs e)
        {
            throw new Exception("This is an error to test exception handling");
        }

        private async void AsyncButtonClick(object sender, RoutedEventArgs e)
        {
            throw new Exception("This is an error to test exception handling");
        }
    }
}
