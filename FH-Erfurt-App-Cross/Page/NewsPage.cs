using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class News : ContentPage
	{
		public News ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


