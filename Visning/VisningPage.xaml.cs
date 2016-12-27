using System;
using Xamarin.Forms;

namespace Visning
{
	public partial class VisningPage : ContentPage
	{
		public VisningPage()
		{
			// Hantera events i code behind...
			InitializeComponent();

			residenceList.ItemsSource = ResidenceFactory.Residences;

			BtnSearch.Clicked += (sender, e) => {

				// TODO: Hämta lista med funna objekt.
				// TODO: Om inga funna objekt - visa text med typ "inga objekt funna".

				lblFoundObjects.IsVisible = true;


			};


		}

		//void BtnSearchClicked(object sender, EventArgs e)
		//{
		//	BtnSearch.Text = "Changed 2";
		//}
	}
}
