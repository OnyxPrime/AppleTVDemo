using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DemoCommon;
using DemoModels;

namespace DemoDataAccessLayer
{
	public class ImageDataAccess : IImageDataAccess
	{
		public ImageDataAccess()
		{
		}

		public async Task<IEnumerable<MonkeeImage>> GetOtherImages(string monkeeName)
		{
			var monkeeImages = new List<MonkeeImage>();
			using (var client = new HttpClient())
			{
				var queryString = HttpUtility.ParseQueryString(string.Empty);

				// Request headers
				client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", AppStuff.BingImageSearchKey);

				// Request parameters
				queryString["q"] = monkeeName;
				queryString["count"] = "10";
				queryString["offset"] = "0";
				queryString["mkt"] = "en-us";
				queryString["safeSearch"] = "Moderate";
				var uri = "https://api.cognitive.microsoft.com/bing/v5.0/images/search?" + queryString;
				var response = await client.GetStringAsync(uri);
				var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(response);
				var images = resultObject.value.Select(i => new MonkeeImage(i.thumbnailUrl, monkeeName)
				);

				monkeeImages = images.ToList();
			}
			return monkeeImages;
		}
	}
}
