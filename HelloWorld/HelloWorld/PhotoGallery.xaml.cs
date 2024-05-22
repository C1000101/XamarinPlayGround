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
	public partial class PhotoGallery : ContentPage
	{
		public PhotoGallery()
		{
			InitializeComponent();
			image.Source = $"https://picsum.photos/id/{imageNumber}/1920/1080/";
		}

		private int imageNumber = 100;
		private int firstImageNumber = 90;
		private int lastImageNumber = 110;

		private void Previous_Clicked(object sender, EventArgs e)
		{
			if (firstImageNumber >= imageNumber)
			{
				imageNumber = lastImageNumber;
			}
			else
			{
				imageNumber--;
			}

			image.Source = $"https://picsum.photos/id/{imageNumber}/1920/1080/";
		}

		private void Next_Clicked(object sender, EventArgs e)
		{
			if (lastImageNumber <= imageNumber)
			{
				imageNumber = firstImageNumber;
			}
			else
			{
				imageNumber++;
			}

			image.Source = $"https://picsum.photos/id/{imageNumber}/1920/1080/";
		}
	}
}