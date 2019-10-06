using Xamarin.Forms.Xaml;

namespace GroupedTable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = App.Locator.MainViewModel;
        }
    }
}