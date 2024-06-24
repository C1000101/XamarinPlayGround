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
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage()
		{
			InitializeComponent();
		}

		async private void BackButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}