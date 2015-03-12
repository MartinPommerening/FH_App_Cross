﻿using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class RootPage : MasterDetailPage
	{
		public RootPage ()
		{
			var menuPage = new MenuPage ();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);

			Master = menuPage;
			Detail = new NavigationPage (new NewsPage());
		}

		void NavigateTo (MenuItem menu)
		{
			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

			Detail = new NavigationPage (displayPage);

			IsPresented = false;
		}

	}
}


