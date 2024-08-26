using CommunityToolkit.Mvvm.Input;
using Java.Net;
using System.Windows.Input;

namespace GesturesLabelSpansFailure
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public ICommand OpenWithIcommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));


        [RelayCommand]
        private async Task OpenWithRelayCommand(string url)
        {
            await Launcher.OpenAsync(url);
        }

        public Command OpenWithCommand => new Command(OpenWebsite);

        private async void OpenWebsite()
        {
            await Launcher.OpenAsync("https://example.com/");
        }
    }
}
