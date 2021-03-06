﻿using System;

using AnimalCrossing.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AnimalCrossing.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
            ViewModel.Initialize(RootFrame);
        }

        
    }
}
