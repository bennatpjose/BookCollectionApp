﻿
namespace BookCollectionApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(BarcodeScanner), typeof(BarcodeScanner));
        }
    }
}
