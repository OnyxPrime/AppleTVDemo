using Foundation;
using System;
using UIKit;
using DemoCommon;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace AppleTvSingleViewDemo
{
    public partial class MonkeesViewController : UIViewController
    {
		private IDataAccess dataAccess;
        public MonkeesViewController (IntPtr handle) : base (handle)
        {
			dataAccess = SimpleLocator.Locator.MonkeeDataAccess;
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.  
			AddMonkeesToNavBar();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private async Task AddMonkeesToNavBar()
		{
			var items = await dataAccess.GetMonkees();
			var navItems = new List<UINavigationItem>();
			var barButtonItems = new List<UIBarButtonItem>();
			foreach (var item in items)
			{
				barButtonItems.Add(new UIBarButtonItem()
				{
					Title = item.Name,
					Enabled = true
				});
			}
			var navItem = new UINavigationItem();
			navItem.SetLeftBarButtonItems(barButtonItems.ToArray(), true);
			navItems.Add(navItem);
			MonkeeNavBar.SetItems(navItems.ToArray(), true);
		}

	}
}