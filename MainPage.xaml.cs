using System;
using System.Linq;
using Microsoft.Maui.Controls;


namespace BookCollectionApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }





        private async void ScanBtn_ClickedAsync(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("BarcodeScanner");
        }

        private void CollectionBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ScanBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
