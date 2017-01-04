using Foundation;
using System;
using UIKit;
using DemoModels;
using System.Threading.Tasks;
using System.Net.Http;

namespace AppleTvSingleViewDemo
{
    public partial class MonkeeViewController : UIViewController
    {
		private Monkee monkeeData;
		public Monkee MonkeeData
		{
			get
			{
				return monkeeData;
			}
			set
			{
				monkeeData = value;
				UpdateScreen();
			}
		}
        public MonkeeViewController (IntPtr handle) : base(handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.  
			UpdateScreen();
		}
		private async Task UpdateScreen()
		{
			if (!IsViewLoaded)
				return;
			MyLabel.Text = MonkeeData.Name;
			MonkeeDescription.Text = MonkeeData.Description;
			MonkeeDescription.SizeToFit();
			MonkeeImage.Image = await UIImageHelper.LoadImageAsync(MonkeeData.ImageUrl);;
		}
    }
}