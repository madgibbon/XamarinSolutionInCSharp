using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSolutionInCSharp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = CreatePage();
            InitializeComponent();
        }
        private View CreatePage()
        {
            var outerStackLayout = new StackLayout()
            {
                Padding=30,
                Children = {
                    new Label(){}
            };
        }
    }
}
