using System;

using Xamarin.Forms;

namespace FHErfurtAppCross
{
	public class Person : ContentPage
	{
		public Person ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


