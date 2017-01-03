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
    [Register ("MonkeeViewController")]
    partial class MonkeeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MonkeeDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MonkeeImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MyLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MonkeeDescription != null) {
                MonkeeDescription.Dispose ();
                MonkeeDescription = null;
            }

            if (MonkeeImage != null) {
                MonkeeImage.Dispose ();
                MonkeeImage = null;
            }

            if (MyLabel != null) {
                MyLabel.Dispose ();
                MyLabel = null;
            }
        }
    }
}