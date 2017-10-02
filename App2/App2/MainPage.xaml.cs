using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{

    public partial class MainPage : ContentPage
	{
        public float clickTotal = 0;
        public Label label;

        public MainPage()
		{
			InitializeComponent();
            
            int clickTotal = 0;

            Label header = new Label
            {
                Text = "Hola que tal amigo",
                Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "K RIKOLINO",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += Holaquetalamigo;

            label = new Label
            {
                Text = "0 RIKOLINAS",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    button,
                    label
                }
            };
        }


        void Holaquetalamigo(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = String.Format("{0} Rikolina{1}",
                                       clickTotal, clickTotal == 1 ? "" : "s");
            DisplayAlert("Hola", "Que tal", "SI!");
        }

    }

}
