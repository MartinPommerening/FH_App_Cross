using System;
using System.Collections.ObjectModel;

namespace FHErfurtAppCross
{
	public class Person
	{
		public Person ()
		{
		}
	}

	public class BlogsViewModel
	{
		public ObservableCollection<Person> Persons { get; set; }
	}
}

