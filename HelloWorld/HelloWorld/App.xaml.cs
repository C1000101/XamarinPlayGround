﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new CoverPage();
			//MainPage = new CreditPage();
			//MainPage = new AbsolutePage();
			//MainPage = new GridPage();
			//MainPage = new StackPage();
			//MainPage = new GreetPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
