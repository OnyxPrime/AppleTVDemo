using System;
using Foundation;
using UIKit;

namespace AppleTvSingleViewDemo
{
	public partial class ViewController : UIViewController
	{
		private int numberOfTimesClicked = 0;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			ClickedLabel.Text = "Button has not been clicked yet.";
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void ButtonPressed(UIButton sender)
		{
			ClickedLabel.Text = $"The button has been clicked {++numberOfTimesClicked} time{((numberOfTimesClicked < 2) ? "" : "s")}";
		}
	}
}

