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

			_contactMethods = GetContactMethods();

			foreach (var method in _contactMethods)
			{
				contactMethods.Items.Add(method.Name);
			}
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

		private void Entry_Completed(object sender, EventArgs e)
		{
			label2.Text = "Completed";
		}

		private void Entry_TextChanged(object sender, TextChangedEventArgs e)
		{
			label2.Text = e.NewTextValue;
		}

		//private void Picker_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	var contactMethod = contactMethods.Items[contactMethods.SelectedIndex];
		//	DisplayAlert("Selection", contactMethod, "OK");
		//}

		private IList<ContactMethod> _contactMethods;
		private void Picker_SelectedIndexChanged(object sender, EventArgs e)
		{
			var name = contactMethods.Items[contactMethods.SelectedIndex];
			var contactMethod = _contactMethods.Single(cm => cm.Name == name);

			DisplayAlert("Selection", name, "OK");
		}

		private IList<ContactMethod> GetContactMethods ()
		{
			return new List<ContactMethod>()
			{
				new ContactMethod { Id = 1, Name = "SMS"},
				new ContactMethod { Id = 2, Name = "Email"},
			};
		}
	}

	public class ContactMethod
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}