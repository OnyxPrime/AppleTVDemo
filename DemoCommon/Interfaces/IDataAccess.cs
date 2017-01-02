using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoModels;

namespace DemoCommon
{
	public interface IDataAccess
	{
		Task<IEnumerable<Monkee>> GetMonkees();
	}
}
