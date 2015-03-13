using System;

namespace FHErfurtAppCross
{
	public static class Urls
	{
		public enum UrlType
		{
			News,
			Person,
			SemesterData,
			Mensa,
			PointsOfIntrest}

		;

		public static string GetUrl (UrlType urlToRetrieve)
		{
			switch (urlToRetrieve) {
			case UrlType.News:
				return "http://blog.falafel.com/Feeds/all-blogs";
			case UrlType.Person:
				return "";
			case UrlType.SemesterData:
				return "";
			case UrlType.Mensa:
				return "";
			case UrlType.PointsOfIntrest:
				return "";
			default:
				return "";
			}
		}
	}
}

