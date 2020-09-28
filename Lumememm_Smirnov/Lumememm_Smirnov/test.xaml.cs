using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_Smirnov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class test : ContentPage
    {
        BoxView hat, head, body, legs;
        Button pea, keha, jalad;
        public test()
        {
            AbsoluteLayout abs=new AbsoluteLayout();
            hat = new BoxView { Color = Color.Red, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(hat, new Rectangle(0.5, 0, 80, 90));
            AbsoluteLayout.SetLayoutFlags(hat, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(hat);
            Content = abs;

            head = new BoxView { Color = Color.Green, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5, 0.1, 100, 100));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(head);
            Content = abs;

            body = new BoxView { Color = Color.Green, CornerRadius = 80 };
            AbsoluteLayout.SetLayoutBounds(body, new Rectangle(0.5, 0.3, 150, 150));
            AbsoluteLayout.SetLayoutFlags(body, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(body);
            Content = abs;

            legs = new BoxView { Color = Color.Green, CornerRadius = 80 };
            AbsoluteLayout.SetLayoutBounds(legs, new Rectangle(0.5, 0.6, 175, 175));
            AbsoluteLayout.SetLayoutFlags(legs, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(legs);
            Content = abs;

            pea = new Button { Text = "hide" };
            pea.Clicked += Btn1_Clicked;
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0, 0.9, 100, 80));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pea);
            Content = abs;

keha = new Button { Text = "hide2" };
            keha.Clicked += Keha_Clicked; ;
            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.3, 0.9, 100, 80));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha);
            Content = abs;

            jalad = new Button { Text = "hide3" };
            jalad.Clicked += Jalad_Clicked; ;
            AbsoluteLayout.SetLayoutBounds(jalad, new Rectangle(0.6, 0.9, 100, 80));
            AbsoluteLayout.SetLayoutFlags(jalad, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(jalad);
            Content = abs;
        }
        bool something = true;
        private void Jalad_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                legs.Opacity = 0;
                flag = false;
            }
            else
            {
                legs.Opacity = 1;
                flag = true;
            }
        }

        bool nothing = true;
        private void Keha_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                body.Opacity = 0;
                flag = false;
            }
            else
            {
                body.Opacity = 1;
                flag = true;
            }
        }

        bool flag = true;
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
head.Opacity = 0;
            flag = false;
            }
                

            else
            {
                head.Opacity = 1;
            flag = true;
            }
        }
        
    }
}