using GroupedTable.ViewModel;
using GroupedTable.Views;

namespace GroupedTable
{
    public partial class App
    {
        private static ViewModelLocator _locator;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static ViewModelLocator Locator => _locator ?? (_locator = new ViewModelLocator());

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}