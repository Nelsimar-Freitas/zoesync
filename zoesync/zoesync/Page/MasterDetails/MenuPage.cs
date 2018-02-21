using Xamarin.Forms;

namespace zoesync.Page.MasterDetails
{
    public class MenuPage : ContentPage
	{
		public ListView Menu { get;	set; }

        public MenuPage()
        {
            var a = new MenuListData();

            Menu = new MenuListView();

            var menuLabel = new ContentView
            {
                Padding = new Thickness( 10, 36, 0, 5 ),
                Content = new Label
                {
                    TextColor = Color.FromHex("3F51B5"),
                    Text = "MENU",
                }
            };

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add( menuLabel );
            layout.Children.Add( Menu );

            Content = layout;
        }


  //      public MenuPage ()
		//{
		//	Icon = "settings.png";
		//	Title = "menu"; // The Title property must be set.
		//	BackgroundColor = Color.FromHex ( "e8e8e8" );                         

  //          Menu = new MenuListView ();

		//	var menuLabel = new ContentView {
		//		Padding = new Thickness (10, 36, 0, 5),
		//		Content = new Label {
		//			TextColor = Color.FromHex ( "A13FB5" ),
		//			Text = "MENU", 
		//		}
		//	};

		//	var layout = new StackLayout { 
		//		Spacing = 0, 
		//		VerticalOptions = LayoutOptions.FillAndExpand
		//	};
		//	layout.Children.Add (menuLabel);
		//	layout.Children.Add (Menu);

		//	Content = layout;
		//}
	}
}

