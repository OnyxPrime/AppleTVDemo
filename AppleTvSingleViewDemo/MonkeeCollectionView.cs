using System;
using UIKit;
namespace AppleTvSingleViewDemo
{
	public class MonkeeCollectionView : UICollectionView
	{
		public MonkeeCollectionView(IntPtr handle) : base(handle)
		{
		}

		#region Override Methods
		public override nint NumberOfSections()
		{
			return 1;
		}

		public override void DidUpdateFocus(UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			var previousItem = context.PreviouslyFocusedView as MonkeeCollectionViewCell;
			if (previousItem != null)
			{
				Animate(0.2, () =>
				{
					//previousItem.CityTitle.Alpha = 0.0f;
				});
			}

			var nextItem = context.NextFocusedView as MonkeeCollectionViewCell;
			if (nextItem != null)
			{
				Animate(0.2, () =>
				{
					//nextItem.CityTitle.Alpha = 1.0f;
				});
			}
		}
		#endregion
	}
}
