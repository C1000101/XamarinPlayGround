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
	public partial class TableViewUserControls : ContentPage
	{
		public void Handel_Tapped(object sender, EventArgs e)
		{
			var page = new ContactMethodsPage();
			page.ContactMethods.ItemSelected += (source, args) =>
			{
				contactMethod.Text = args.SelectedItem.ToString();
				Navigation.PopAsync();
			};

			Navigation.PushAsync(page);
		}

		public TableViewUserControls()
		{
			InitializeComponent();
		}
	}
}