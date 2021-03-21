using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewTraining
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new CVWithSelection();
            //MainPage = new CVWithRefresh();
            MainPage = new CVWithContextMenu();
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
