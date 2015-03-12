using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class NewsPage : ContentPage
	{
		public NewsPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


