// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AppleTvSingleViewDemo
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ClickedLabel { get; set; }

        [Action ("ButtonPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonPressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ClickedLabel != null) {
                ClickedLabel.Dispose ();
                ClickedLabel = null;
            }
        }
    }
}