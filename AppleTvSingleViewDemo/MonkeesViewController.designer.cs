// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AppleTvSingleViewDemo
{
    [Register ("MonkeesViewController")]
    partial class MonkeesViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClickMe { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageMain { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelDescription { get; set; }

        [Action ("GoMonkee:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GoMonkee (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ClickMe != null) {
                ClickMe.Dispose ();
                ClickMe = null;
            }

            if (ImageMain != null) {
                ImageMain.Dispose ();
                ImageMain = null;
            }

            if (LabelDescription != null) {
                LabelDescription.Dispose ();
                LabelDescription = null;
            }
        }
    }
}