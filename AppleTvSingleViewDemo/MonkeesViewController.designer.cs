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
        UIKit.UINavigationBar MonkeeNavBar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MonkeeNavBar != null) {
                MonkeeNavBar.Dispose ();
                MonkeeNavBar = null;
            }
        }
    }
}