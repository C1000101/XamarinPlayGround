using HelloWorld.ViewModels;
using MvvmDemo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Drawing;

namespace MvvmDemo
{
	public class PlaylistViewModel : BaseViewModel
	{
		public string Title { get; set; }

		private bool _isFavorite;
		public bool IsFavorite
		{
			get { return _isFavorite; }
			set
			{
				SetValue(ref _isFavorite, value);
				OnPropertyChanged(nameof(Color));
			}
		}

		public Color Color
		{
			get { return IsFavorite ? Color.Pink : Color.Black; }
		}
	}
}
