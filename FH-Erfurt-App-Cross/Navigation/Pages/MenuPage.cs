using System;
using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class MenuPage : ContentPage
	{
		public ListView Menu { get; set; }

		public MenuPage ()
		{
			//Icon = "settings.png";
			Title = "menu"; // The Title property must be set.
			BackgroundColor = Color.FromHex ("333333");
			Menu = new MenuListView ();

			var layout = new StackLayout { 
				Spacing = 0, 
				VerticalOptions = LayoutOptions.FillAndExpand,

			};
			layout.Children.Add (Menu);

			Content = layout;
		}
	}
}


