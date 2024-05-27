using HelloWorld.Models;
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
	public partial class BasicList : ContentPage
	{
		public BasicList()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact>
			{ 
				new Contact { Name = "Smith", ImageUrl = "https://picsum.photos/id/1/1920/1080/" },
				new Contact { Name = "John", ImageUrl = "https://picsum.photos/id/2/1920/1080/", Status = "Hey, lets talk!"},
			};
		}
	}
}