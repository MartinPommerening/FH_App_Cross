using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Xml.Linq;

namespace FHErfurtAppCross
{
	public class DataLoader
	{
		public async Task<List<NewsEntry>> GetRecentBlogs ()
		{
			using (var httpClient = new HttpClient ()) {
				Stream data =
					await httpClient.GetStreamAsync (
						Urls.GetUrl (Urls.UrlType.News));
				List<NewsEntry> blogs = await Task.Run (() =>
					GetNewsList(data));
				return blogs;
			}
		}

		private List<NewsEntry> GetNewsList (Stream blogRSSData)
		{
			IEnumerable<XElement> items = XElement.Load (
				blogRSSData).Descendants ("item");

			var newsList = (from blog in items
				select new NewsEntry () {
					id = blog.Element ("id").Value,
					name = blog.Element ("name").Value,
					url = blog.Element ("url").Value,
				}).ToList<NewsEntry> ();

			return newsList;
		}
	}
}

