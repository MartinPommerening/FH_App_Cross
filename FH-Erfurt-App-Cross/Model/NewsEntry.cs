using System;

namespace FHErfurtAppCross
{
	public class Authorization
	{
		public string url { get; set; }
		public int id { get; set; }
		public int pid { get; set; }
		public string logintype { get; set; }
	}

	public class NewsEntry
	{
		public int id { get; set; }
		public string name { get; set; }
		public string url { get; set; }
		public Authorization authorization { get; set; }
		public bool authorizationRequired { get; set; }
	}
}

