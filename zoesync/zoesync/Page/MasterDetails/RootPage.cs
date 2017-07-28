using System;
using Xamarin.Forms;

namespace zoesync.Page.MasterDetails
{
	public class RootPage : MasterDetailPage
	{
		public RootPage ()
		{
			var menuPage = new MenuPage();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);    
			Master = menuPage;
			Detail = new NavigationPage (new HomePage());
		}

		void NavigateTo (MenuItem menu)
		{
            Xamarin.Forms.Page displayPage = (Xamarin.Forms.Page)Activator.CreateInstance (menu.TargetType);

			Detail = new NavigationPage (displayPage);

			IsPresented = false;
		}
	}
}

