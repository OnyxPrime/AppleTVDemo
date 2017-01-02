using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCommon;
using DemoModels;

namespace DemoDataAccessLayer
{
	public class TestDataAccess : IDataAccess
	{

		private IEnumerable<Monkee> monkees;

		public TestDataAccess()
		{
		}

		public Task<IEnumerable<Monkee>> GetMonkees()
		{
			if (monkees == null)
				GenerateMonkees();
			return Task.FromResult(monkees);
		}

		private void GenerateMonkees()
		{
			var tmp = new List<Monkee>();

			tmp.Add(new Monkee()
			{
				Name = "Mike Nesmith",
				Description = "Robert Michael Nesmith is an American musician, songwriter, actor, producer, novelist, businessman, and philanthropist, best known as a member of the pop rock band the Monkees and co-star of the TV series The Monkees.",
				ImageUrl = "https://goo.gl/images/YQeZ1p"
			});

			tmp.Add(new Monkee()
			{
				Name = "Davy Jones",
				Description = "David Thomas \"Davy\" Jones was an English singer-songwriter, musician, actor and businessman best known as a member of the band The Monkees, and for starring in the TV series of the same name.",
				ImageUrl = "https://goo.gl/images/QlonPK"
			});

			tmp.Add(new Monkee()
			{
				Name = "Mickey Dolenz",
				Description = "George Michael \"Micky\" Dolenz, Jr. is an American actor, musician, television director, radio personality and theater director, best known as the drummer and principal lead singer of the 1960s pop/rock band the Monkees.",
				ImageUrl = "https://goo.gl/images/87vmwA"
			});

			tmp.Add(new Monkee()
			{
				Name = "Peter Tork",
				Description = "Peter Tork is an American musician and actor, best known as the keyboardist and bass guitarist of the Monkees.",
				ImageUrl = "https://goo.gl/images/PAz9vj"
			});

			monkees = tmp;
		}
	}
}
