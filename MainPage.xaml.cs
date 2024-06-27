using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExcuseManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ExcuseManager excuseManager;
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = excuseManager = new ExcuseManager();
        }

        private void OpenButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenExcuseAsync();
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsync();
        }

        private void NewExcuseButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.NewExcuseAsync();
        }

        private void SaveAsButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsAsync();
        }

        private void RandomExcuseButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenRandomExcuseAsync();
        }

        private async void FolderButtonClick(object sender, RoutedEventArgs e)
        {
            bool folderChosen = await excuseManager.ChooseNewFolderAsync();
            if (folderChosen)
            {
                saveButton.IsEnabled = true;
                randomButton.IsEnabled = true;
            }
        }

        private void SetToCurrentTimeClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
