using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		async public void Handel_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			Contact contact = e.SelectedItem as Contact;
			await Navigation.PushAsync(new ContactDetailPage(contact));
			listView.SelectedItem = null;
		}

		public ContactsPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact>
			{
				new Contact { Name = "Bob", ImageUrl = "https://picsum.photos/id/2/1920/1080/"},
				new Contact { Name = "Ali", ImageUrl = "https://picsum.photos/id/2/1920/1080/"},
			};
		}
	}
}