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
	public partial class GreetPage : ContentPage
	{
		public GreetPage()
		{
			InitializeComponent();

			slider.Value = 0.5;
			label.Text = textPreFix;
		}

		private int quoteIndexer = 0;

		private string[] quotes = new string[]
		{
			"Life is the punishment and death is the reward.",
			"I hope existence had a point.",
			"Why is it called living when you're really dyeing.",
			"People are animals but they are not aware of it.",
			"Launch all the nuks. WWIII sounds like fun."
		};
		
		string textPreFix = "Font Size: ";

		private void Button1_Click(object sender, EventArgs e)
		{
			if (quoteIndexer >= quotes.Length)
			{
				quoteIndexer = 0;
			}

			quoteLabel.Text = quotes[quoteIndexer];
			quoteIndexer++;
		}

		void Slider_ValueChanged(object sender, EventArgs e)
		{
			var slider = (Xamarin.Forms.Slider)sender;
			var fontSizeScaler = 100;

			quoteLabel.FontSize = slider.Value * fontSizeScaler;
			label.Text = textPreFix + (slider.Value * fontSizeScaler).ToString();
		}
	}
}