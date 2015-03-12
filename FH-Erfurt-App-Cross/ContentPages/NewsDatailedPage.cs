using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class NewsDatailedPage : ContentPage
	{
		public NewsDatailedPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


