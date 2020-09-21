using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_Smirnov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememm : ContentPage
    {
        
        public Lumememm()
        {
            InitializeComponent();
        }

        private async void one_Clicked(object sender, EventArgs e)
        {

                hat.Opacity = 0;
            head.Opacity = 0;
            body.Opacity = 0;
            legs.Opacity = 0;

        }

        private async void two_Clicked(object sender, EventArgs e)
        {

                hat.Opacity = 1;
            head.Opacity = 1;
            body.Opacity = 1;
            legs.Opacity = 1;

        }
        Random rnd = new Random();
        private void Color_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            hat.BackgroundColor = new Color(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            head.BackgroundColor = new Color(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            body.BackgroundColor = new Color(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            legs.BackgroundColor = new Color(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            
            
        }

        private async void hot_Clicked(object sender, EventArgs e)
        {
            hat.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
            head.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
            body.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
            legs.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
        }

        private void three_Clicked(object sender, EventArgs e)
        {

        }
    }
}