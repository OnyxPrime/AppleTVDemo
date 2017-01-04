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
		//private IDataAccess dataAccess;
		UIViewController monkeeVC;
        public MonkeesViewController (IntPtr handle) : base (handle)
        {
			//dataAccess = SimpleLocator.Locator.MonkeeDataAccess;
        }

		public void Initialize()
		{
			monkeeVC = new MonkessTabViewController();
		}

		public override void AwakeFromNib()
		{
			this.Initialize();
			base.AwakeFromNib();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			LabelDescription.SizeToFit();
			// Perform any additional setup after loading the view, typically from a nib.  
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void GoMonkee(UIButton sender)
		{
			this.NavigationController.PushViewController(monkeeVC, true);
		}
	}
}