using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			if (Application.Current.Properties.ContainsKey("Name"))
				title.Text = Application.Current.Properties["Name"].ToString();

			if (Application.Current.Properties.ContainsKey("NotificationEnabled"))
				notificationEnabled.On = (bool)Application.Current.Properties["NotificationEnabled"];
		}

		public void OnChanged(object sender, EventArgs e)
		{
			Application.Current.Properties["Name"] = title.Text;
			Application.Current.Properties["NotificationEnabled"] = notificationEnabled.On;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
		}
	}
}
