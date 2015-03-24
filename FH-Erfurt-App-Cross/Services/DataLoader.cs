using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace FHErfurtAppCross
{
	public class DataLoader
	{
		public async Task<List<NewsEntry>> GetRecentBlogs ()
		{
			using (var httpClient = new HttpClient ()) {
				String data =
					await httpClient.GetStringAsync (
						Urls.GetUrl (Urls.UrlType.News));
				List<NewsEntry> blogs = await Task.Run (() =>
					GetNewsList(data));
				return blogs;
			}
		}

		private List<NewsEntry> GetNewsList (String blogRSSData)
		{
			Entrys entrys = new Entrys ();
			entrys.entries = JsonConvert.DeserializeObject<List<NewsEntry>> (blogRSSData);


//			IEnumerable<XElement> items = XElement.Load (
//				blogRSSData).Descendants ("item");

//			var newsList = (from blog in items
//				select new NewsEntry () {
//					id = blog.Element ("id").Value,
//					name = blog.Element ("name").Value,
//					url = blog.Element ("url").Value,
//				}).ToList<NewsEntry> ();
//
//			return newsList;
		}
	}
}

