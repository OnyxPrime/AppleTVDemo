using System;
using Newtonsoft.Json;

namespace DemoModels
{
	public class SearchResult
	{
		[JsonProperty("thumbnailUrl")]
		public string ThumbnailUrl { get; set; }
		[JsonProperty("contentUrl")]
		public string ContentUrl { get; set; }
	}
}
