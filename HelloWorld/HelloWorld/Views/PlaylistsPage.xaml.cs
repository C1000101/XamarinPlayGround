using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmDemo
{
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsPage ()
        {
            BindingContext = new PlaylistViewModel();
            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
        }

        void OnAddPlaylist (object sender, System.EventArgs e)
        {
            (BindingContext as PlaylistViewModel).AddPlaylist();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistViewModel)
                .SelectPlaylist(e.SelectedItem as Playlist);
        }
    }
}
