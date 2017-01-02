using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCommon;
using DemoModels;

namespace DemoDataAccessLayer
{
	public class DataAccess : IDataAccess
	{
		public DataAccess()
		{
		}

		public Task<IEnumerable<Monkee>> GetMonkees()
		{
			throw new NotImplementedException();
		}
	}
}
