using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

			//image.Source = ImageSource.FromResource("HelloWorld.Images.background.jpg");

			//var imageSource = new UriImageSource { Uri = new Uri("https://picsum.photos/1920/1080") };
			//imageSource.CachingEnabled = false;
			//imageSource.CacheValidity = TimeSpan.FromHours(1);
			//image.Source = imageSource;
		}
	}
}