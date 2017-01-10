using System;
namespace DemoModels
{
	public class MonkeeImage
	{
		private string url;
		private string title;

		public string Url { get { return url; } }
		public string Title { get { return title; } }
		public MonkeeImage(string url, string title)
		{
			this.url = url;
			this.title = title;
		}
	}
}
