﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPage : ContentPage
	{
		public GridPage()
		{
			InitializeComponent();

			return;

			var grid = new Grid();

		}
	}
}