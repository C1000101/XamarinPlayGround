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
	public partial class UsserControl : ContentPage
	{
		public UsserControl()
		{
			InitializeComponent();
		}

		private void Switch_Toggled(object sender, ToggledEventArgs e)
		{
			label.IsVisible = e.Value;
        }

		private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			double temp = e.OldValue;
			temp = e.NewValue;
		}
	}
}