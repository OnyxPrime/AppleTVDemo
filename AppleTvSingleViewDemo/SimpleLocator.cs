using System;
using DemoCommon;
using DemoDataAccessLayer;

namespace AppleTvSingleViewDemo
{
	public class SimpleLocator
	{
		private static SimpleLocator locator;
		public static SimpleLocator Locator
		{
			get
			{
				if (locator == null)
					locator = new SimpleLocator();
				return locator;
			}
		}
		protected SimpleLocator()
		{
		}

		private IDataAccess monkeeDataAccess = new TestDataAccess();
		public IDataAccess MonkeeDataAccess
		{
			get
			{
				return monkeeDataAccess;
			}
		}

		private IImageDataAccess monkeeImageDataAccess = new ImageDataAccess();
		public IImageDataAccess MonkeeImageDataAccess
		{
			get
			{
				return monkeeImageDataAccess;
			}
		}
	}
}
