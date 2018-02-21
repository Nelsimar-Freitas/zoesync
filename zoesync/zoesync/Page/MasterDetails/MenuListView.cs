using System.Collections.Generic;
using Xamarin.Forms;

namespace zoesync.Page.MasterDetails
{
    public class MenuListView : ListView
	{
		public MenuListView ()
		{
            List<MenuItem> data = new MenuListData();
            ItemsSource = data;
			VerticalOptions = LayoutOptions.FillAndExpand;
			BackgroundColor = Color.Transparent;
            RowHeight = 60;
            SeparatorVisibility = SeparatorVisibility.None;
            BackgroundColor = Color.FromHex("#3F51B5");


            var cell = new DataTemplate (typeof(ImageCell));
			cell.SetBinding(TextCell.TextProperty, "Title");
			cell.SetBinding (ImageCell.ImageSourceProperty, "IconSource");
            cell.SetBinding(TextCell.TextColorProperty, "Black");

			ItemTemplate = cell;
			SelectedItem = data [0];              

        }
	}
}

