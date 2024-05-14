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
	public partial class PhoneNumber : ContentPage
	{
		public PhoneNumber()
		{
			InitializeComponent();

			Label1.Text = "";
		}

		

		private void Button0_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "0";
		}
		private void Button1_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "1";
		}
		private void Button2_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "2";
		}
		private void Button3_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "3";
		}
		private void Button4_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "4";
		}
		private void Button5_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "5";
		}
		private void Button6_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "6";
		}
		private void Button7_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "7";
		}
		private void Button8_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "8";
		}
		private void Button9_Clicked(object sender, EventArgs e)
		{
			Label1.Text += "9";
		}

		private void Dial_Clicked(object sender, EventArgs e)
		{
			Label1.Text = string.Empty;
		}
	}
}