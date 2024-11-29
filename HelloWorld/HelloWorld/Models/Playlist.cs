using HelloWorld.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MvvmDemo
{
    public class Playlist : BaseViewModel 
    {
        public string Title { get; set; }
        public bool IsFavorite { get; set; }
    }
}
