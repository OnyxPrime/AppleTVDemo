using System;
using UIKit;
using DemoModels;
using CoreGraphics;
using System.Threading.Tasks;

namespace AppleTvSingleViewDemo
{
	public class MonkeeCollectionViewCell : UICollectionViewCell
	{
		#region Private Variables
		private MonkeeImage monkee;
		#endregion

		#region Computed Properties
		public UIImageView MonkeeView { get; set; }

		public MonkeeImage Monkee
		{
			get { return monkee; }
			set
			{
				monkee = value;
				LoadImage();
			}
		}
		#endregion

		public MonkeeCollectionViewCell()
		{
			// Initialize
			MonkeeView = new UIImageView(new CGRect(22, 19, 320, 171));
			MonkeeView.AdjustsImageWhenAncestorFocused = true;
			AddSubview(MonkeeView);

		}

		private async Task LoadImage()
		{
				MonkeeView.Image = await UIImageHelper.LoadImageAsync(Monkee.Url);
		}
	}
}
