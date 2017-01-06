using AVKit;
using Foundation;
using System;
using AVFoundation;
using System.Net;

namespace AppleTvSingleViewDemo
{
    public partial class StreamingDemo : AVPlayerViewController
    {
        public StreamingDemo (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			PlayMovie();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			PlayMovie();
		}

		private void PlayMovie()
		{
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = UIImageHelper.MyRemoteCertificateValidationCallback;
				if (this.Player != null)
				{
					if (this.Player.TimeControlStatus == AVPlayerTimeControlStatus.Paused)
						this.Player.Play();
				}
				else {
					this.Player = new AVPlayer(new NSUrl("http://184.72.239.149/vod/smil:BigBuckBunny.smil/playlist.m3u8"));
					this.Player.Play();
				}
			}
			catch (Exception ex)
			{
			}
		}
    }
}