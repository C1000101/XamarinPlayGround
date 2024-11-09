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
	public partial class UserControlsTwo : ContentPage
	{
		Page mainPage { get; set; }	
		List<ContentPage> pages;
		int pageIndex = 0;

		public UserControlsTwo(Page _mainPage)
		{
			InitializeComponent();
			this.mainPage = _mainPage;
			pages = new List<ContentPage>();
			pages.Add(this);
			pages.Add(new TableViewUserControls());
		}

		private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
		{

        }

		private void Button_Clicked(object sender, EventArgs e)
		{

		}

		//private void ButtonNext_Cliecked(object sender, EventArgs e)
		//{
		//	if (pageIndex == 0)
		//	{
		//		pageIndex = 1;
		//		mainPage = pages[pageIndex];
		//		mainPage.ForceLayout();
		//	}
		//}

		//private void ButtonBack_Clicked(object sender, EventArgs e)
		//{
		//	if (pageIndex == 1)
		//	{
		//		pageIndex = 0;
		//		mainPage = pages[pageIndex];
		//		mainPage.ForceLayout();
		//	}
		//}
	}
}