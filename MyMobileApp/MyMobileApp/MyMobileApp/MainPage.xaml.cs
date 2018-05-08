using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyMobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            myButton.Clicked += MyButton_Clicked;
		}

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            // Di sini Le.. pindahin tulisan yg ada di myEntry ke myLabel
            myLabel.Text = myEntry.Text;
        }
    }
}
