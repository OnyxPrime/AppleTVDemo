using System;
using System.Net.Http;
using Foundation;
using UIKit;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net;

namespace AppleTvSingleViewDemo
{
	public static class UIImageHelper
	{
		
		public static async Task<UIImage> LoadImageAsync(string uri)
		{
			var httpClient = new HttpClient();
			ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;
			var contentsTask = httpClient.GetByteArrayAsync(uri);
			var contents = await contentsTask;
			var data = NSData.FromArray(contents);
			var image = UIImage.LoadFromData(data);
			return image;
		}

		public static bool MyRemoteCertificateValidationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			bool isOk = true;
			// If there are errors in the certificate chain, look at each error to determine the cause.
			if (sslPolicyErrors != SslPolicyErrors.None)
			{
				for (int i = 0; i < chain.ChainStatus.Length; i++)
				{
					if (chain.ChainStatus[i].Status != X509ChainStatusFlags.RevocationStatusUnknown)
					{
						chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
						chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
						chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 1, 0);
						chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
						bool chainIsValid = chain.Build((X509Certificate2)certificate);
						if (!chainIsValid)
						{
							isOk = false;
						}
					}
				}
			}
			return isOk;
		}
	}
}
