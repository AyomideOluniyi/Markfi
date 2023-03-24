using System;
using System.Collections.Generic;
using Markfi.ViewModels;
using Markfi.Views;
using Xamarin.Forms;

namespace Markfi
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
