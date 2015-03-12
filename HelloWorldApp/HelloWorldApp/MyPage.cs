using System;

using Xamarin.Forms;

namespace HelloWorldApp
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" },
					new Label{Text = "Hello ContentPage2"}
				}
			};
		}
	}
}


