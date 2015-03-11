using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class PersonDatailedPage : ContentPage
	{
		public PersonDatailedPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


