using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zoesync.Page.MasterDetails
{

    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class MainPage : MasterDetailPage
    {

        public List<MenuItem> _menuList { get; set; }

        public MainPage()
        {   
            InitializeComponent();    
            Menus();
            Detail = new NavigationPage( new HomePage() );
            //Detail = new NavigationPage( (Xamarin.Forms.Page)Activator.CreateInstance( typeof( ContractsPage ) ) );
        }

        private void Menus()
        {   
            List<MenuItem> data = new MenuListData();
            navigationDrawerList.ItemsSource = data;
        }  

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {             
            var item = (MenuItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage( (Xamarin.Forms.Page)Activator.CreateInstance( page ) );
            IsPresented = false;
        }
    }
}
