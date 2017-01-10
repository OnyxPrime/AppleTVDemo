using System;
using Foundation;
using UIKit;
namespace AppleTvSingleViewDemo
{
	public class MonkeeViewDatasource : UICollectionViewDataSource
	{
		public MonkeeViewDatasource()
		{
		}

		public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new NotImplementedException();
		}

		public override nint GetItemsCount(UICollectionView collectionView, nint section)
		{
			throw new NotImplementedException();
		}
	}
}
