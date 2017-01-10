using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using DemoModels;
namespace DemoCommon
{
	public interface IImageDataAccess
	{
		Task<IEnumerable<MonkeeImage>> GetOtherImages(string MonkeeName);
	}
}
