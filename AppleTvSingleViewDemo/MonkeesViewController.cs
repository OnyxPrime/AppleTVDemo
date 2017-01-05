using Foundation;
using System;
using UIKit;
using DemoCommon;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using MediaPlayer;
using CoreGraphics;
using AVFoundation;

namespace AppleTvSingleViewDemo
{
    public partial class MonkeesViewController : UIViewController
    {

		UIViewController monkeeVC;
		StreamingDemo streamingVC;
        public MonkeesViewController (IntPtr handle) : base (handle)
        {
        }

		public void Initialize()
		{
			monkeeVC = new MonkessTabViewController();
			var storyboard = UIStoryboard.FromName("Main", null);
			streamingVC = (StreamingDemo)storyboard.InstantiateViewController("StreamingTest");
		}

		public override void AwakeFromNib()
		{
			this.Initialize();
			base.AwakeFromNib();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//// Perform any additional setup after loading the view, typically from a nib.  
			SetupMain();
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

		partial void GoMovie(UIButton sender)
		{
			this.NavigationController.PushViewController(streamingVC, true);
		}

		private async Task SetupMain()
		{
			LabelDescription.SizeToFit();
			try
			{
				ImageMain.Image = await UIImageHelper.LoadImageAsync("https://upload.wikimedia.org/wikipedia/commons/e/ed/The_Monkees.jpg");
			}
			catch (Exception e)
			{
			}
		}
	}
}