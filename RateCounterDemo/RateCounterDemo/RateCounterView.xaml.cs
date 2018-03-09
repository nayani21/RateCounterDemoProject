using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;
using Xamarin.Forms;

namespace RateCounterDemo
{
    public partial class RateCounterView : ContentPage
    {
        public RateCounterView()
        {
            // InitializeComponent();
            RateCounter SampleLayout = new RateCounter();
            SampleLayout.width = 258;
            SampleLayout.hight = 60;
            StackLayout Sample = SampleLayout.testpage(50, Color.Green);//this is the default image which has been provided as default image.     
                
            SampleLayout.width = 155;
            SampleLayout.hight = 59;
            StackLayout Sample1 = SampleLayout.testpage(12, Color.Blue,"three_ratingTransparent.png");//this is the image which has been used under Resouces folder in Android project.
            var layout = new StackLayout();
            layout.Children.Add(Sample);
            layout.Children.Add(Sample1);
            Content = layout;
        }
    }
}
