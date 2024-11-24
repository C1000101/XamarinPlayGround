using HelloWorld.ViewModels;
using MvvmDemo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvmDemo
{
	internal class PlaylistViewModel : BaseViewModel
	{
		public ObservableCollection<Playlist> Playlists { get; private set; } =
			new ObservableCollection<Playlist>();

		private Playlist _selectedPlaylist;
		public Playlist SelectedPlaylist 
		{
			get { return _selectedPlaylist; }
			set { SetValue(ref _selectedPlaylist, value); }
		}

		public void AddPlaylist()
		{
			var newPlaylist = "Playlist " + (Playlists.Count + 1);
			Playlists.Add(new Playlist { Title = newPlaylist });
		}

		public void SelectPlaylist(Playlist playlist)
		{
			if (playlist == null)
				return;

			playlist.IsFavorite = !playlist.IsFavorite;

			SelectedPlaylist = null;

			//await Navigation.PushAsync (new PlaylistDetailPage(playlist));
		}
	}
}
