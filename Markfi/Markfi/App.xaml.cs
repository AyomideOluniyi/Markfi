using System;
using Markfi.Services;
using Markfi.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Markfi
{
    public partial class App : Application
    {
        public static object Database { get; internal set; }




        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainMenuPage());
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
