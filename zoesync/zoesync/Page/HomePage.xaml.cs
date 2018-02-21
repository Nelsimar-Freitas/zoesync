using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zoesync.Page
{

    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {                
            InitializeComponent();

            Title = "Yes Doctor";
            //Icon = "Contracts.png";

            BindingContext = new HomePageViewModel();
        }
    }

    class HomePageViewModel : INotifyPropertyChanged
    {

        public HomePageViewModel()
        {
            IncreaseCountCommand = new Command( IncreaseCount );
        }

        int count;

        string countDisplay = "You clicked 0 times.";
        public string CountDisplay
        {
            get { return countDisplay; }
            set { countDisplay = value; OnPropertyChanged(); }
        }

        public ICommand IncreaseCountCommand { get; }

        void IncreaseCount() =>
            CountDisplay = $"You clicked {++count} times";


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );

    }
}
