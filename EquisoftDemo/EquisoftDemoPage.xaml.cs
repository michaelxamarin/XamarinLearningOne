using System;
using Xamarin.Forms;

namespace EquisoftDemo
{
	public partial class EquisoftDemoPage : ContentPage
	{
		public EquisoftDemoPage()
		{
			InitializeComponent();

			Title = "Awesome App";
		}

		void ButtonClicked(object sender, EventArgs e)
		{
			//Button button = (Button)sender;
			//button.Text = button.Text + '!';

			//MyLabel.Text = "Clicked";

			Navigation.PushAsync(new MyPage(),true);


		}

	}
}
