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
                Padding = 30,
                Children = {
                    new Label(){
                        FontSize=20,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new StackLayout(){
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Label(){ Text="Customer"},
                            new Entry(){ Placeholder = "Full Name"}
                        }
                    },
                    new Button(){
                        Text = "Click me"
                    }
                }
            };
            return outerStackLayout;
        }
    }
}