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
	public partial class BasicList : ContentPage
	{
		private ObservableCollection<Contact> _contacts;

		public BasicList()
		{
			InitializeComponent();

			_contacts = new ObservableCollection<Contact>
			{
				new Contact { Name = "Ali", ImageUrl = "https://picsum.photos/id/1/1920/1080/" },
				new Contact { Name = "Bob", ImageUrl = "https://picsum.photos/id/2/1920/1080/", Status = "Hey, lets talk!"},
			};

			listView.ItemsSource = _contacts;

			//listView.ItemsSource = new List<Contact>
			//{
			//	new Contact { Name = "Ali", ImageUrl = "https://picsum.photos/id/1/1920/1080/" },	
			//	new Contact { Name = "Bob", ImageUrl = "https://picsum.photos/id/2/1920/1080/", Status = "Hey, lets talk!"},
			//};

			//listView.ItemsSource = new List<ContactGroup>
			//{
			//	new ContactGroup("A", "A")
			//	{
			//		new Contact { Name = "Ali", ImageUrl = "https://picsum.photos/id/1/1920/1080/" },
			//	},

			//	new ContactGroup("B", "B")
			//	{
			//		new Contact { Name = "Bob", ImageUrl = "https://picsum.photos/id/2/1920/1080/", Status = "Hey, lets talk!"},
			//	},
			//};
		}

		private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Tapped", contact.Name, "OK");
		}

		private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			DisplayAlert("Selected", contact.Name, "OK");
		}

		private void Call_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Contact;

			DisplayAlert("Cell", contact.Name, "OK");
		}

		private void Delete_Clicked(object sender, EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact;
			_contacts.Remove(contact);
		}
	}
}