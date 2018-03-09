using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RateCounterDemo
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application        
        }

        protected override void OnStart()
        {
            MainPage = new RateCounterView();
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
