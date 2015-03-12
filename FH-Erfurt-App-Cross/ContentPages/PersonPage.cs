using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class PersonPage : ContentPage
	{
		public PersonPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


