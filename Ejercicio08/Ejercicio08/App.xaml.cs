using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio08
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new ExplicitDemo();
            //MainPage = new ExplicitControlDemo();
            //MainPage = new ImplicitDemo();
            //MainPage = new ImplicitControlDemo();
            //MainPage = new GlobalDemo();
            //MainPage = new InheritanceDemo();
            //MainPage = new DynamicDemo();
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
