using Foundation;
using System;
using UIKit;
using DemoModels;
using System.Threading.Tasks;
using System.Net.Http;
using DemoCommon;
using System.Linq;

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
				LoadPrimaryInfo();
			}
		}

		private IImageDataAccess imageDataAccess;
		public IImageDataAccess ImageDataAccess
		{
			get { return imageDataAccess; }
			set { imageDataAccess = value; }
		}

        public MonkeeViewController (IntPtr handle) : base(handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.  
			LoadPrimaryInfo();
			LoadSecondaryInfo();
		}
		private async Task LoadPrimaryInfo()
		{
			if (!IsViewLoaded)
				return;
			MyLabel.Text = MonkeeData.Name;
			MonkeeDescription.Text = MonkeeData.Description;
			MonkeeDescription.SizeToFit();
			MonkeeImage.Image = await UIImageHelper.LoadImageAsync(MonkeeData.ImageUrl);
		}

		private async Task LoadSecondaryInfo()
		{
			var results = await ImageDataAccess.GetOtherImages(MonkeeData.Name);
			var count = results.Count();
		}
    }
}