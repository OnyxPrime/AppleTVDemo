using Foundation;
using System;
using UIKit;
using DemoCommon;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace AppleTvSingleViewDemo
{
    public partial class MonkessTabViewController : UITabBarController
    {
		UIViewController[] tabs;
		private IDataAccess dataAccess;
		public MonkessTabViewController ()
        {
			dataAccess = SimpleLocator.Locator.MonkeeDataAccess;
			ViewControllers = new UIViewController[] { new UIViewController() { Title = "Test" } };
			AddMonkeeTabs();
        }

		private async Task AddMonkeeTabs()
		{
			var tabsList = new List<UIViewController>();
			var items = await dataAccess.GetMonkees();
			foreach (var item in items)
			{
				try
				{
					//var tab = new MonkeeViewController();
					var storyboard = UIStoryboard.FromName("Main", null);
					var t2 = (MonkeeViewController)storyboard.InstantiateViewController("MonkeeMain");
					t2.Title = item.Name;
					t2.MonkeeData = item;
					tabsList.Add(t2);
				}
				catch (Exception ex)
				{
				}
			}
			tabs = tabsList.ToArray();
			ViewControllers = tabsList.ToArray();
		}
    }
}