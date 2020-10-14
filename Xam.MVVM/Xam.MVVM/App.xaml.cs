using System;
using Xam.MVVM.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EmployeesPage();
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
