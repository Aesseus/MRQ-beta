using Microsoft.Maui.Graphics;
using Microcharts;
using Microcharts.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using System.Diagnostics;

namespace MRQ
{
    public partial class MainPage : ContentPage
    {
        private int buttonSize = 50;

        public MainPage()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
            this.BackgroundColor = Color.FromArgb("#9bd5d4");
            BuildUI();
        }

        private void BuildUI()
        {
            var grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },     // Settings icon
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },  // Donut Chart
                    new RowDefinition { Height = GridLength.Auto },     // Review Expenses Button
                    new RowDefinition { Height = GridLength.Auto },     // Labels
                    new RowDefinition { Height = GridLength.Auto }      // Bottom navigation bar
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }
                },
                BackgroundColor = Colors.Transparent
            };

            AddSettingsIcon(grid);
            AddDonutChart(grid);
            AddReviewButton(grid);
            AddLabels(grid);
            AddNavigationBar(grid);
            

            Content = grid;
        }

        private void AddSettingsIcon(Grid grid)
        {
            var settingsButton = new ImageButton
            {
                Source = "settings.png", // Ensure image path is correct
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            settingsButton.Pressed += OnButtonPressed;
            settingsButton.Released += OnButtonReleased;

            var settingsFrame = new Frame
            {
                WidthRequest = 70,
                HeightRequest = 70,
                Padding = new Thickness(0),
                Content = settingsButton,
                BackgroundColor = Colors.Transparent,
                BorderColor = Colors.Transparent,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };

            grid.Children.Add(settingsFrame);
            Grid.SetRow(settingsFrame, 0);
        }

        private void AddDonutChart(Grid grid)
        {
            // Dummy data for the donut chart
            var entries = new[]
            {
                new ChartEntry(200) { Color = SkiaSharp.SKColor.Parse("#FF1943"), Label = "Car", ValueLabel = "200" },
                new ChartEntry(400) { Color = SkiaSharp.SKColor.Parse("#ffa600"), Label = "Flame", ValueLabel = "400" },
                new ChartEntry(300) { Color = SkiaSharp.SKColor.Parse("#8BC34A"), Label = "Plane", ValueLabel = "300" },
                new ChartEntry(300) { Color = SkiaSharp.SKColor.Parse("#5b4fb4"), Label = "Shopping", ValueLabel = "300" },
                new ChartEntry(300) { Color = SkiaSharp.SKColor.Parse("#092327"), Label = "Plane", ValueLabel = "300" },
                new ChartEntry(300) { Color = SkiaSharp.SKColor.Parse("#78a300"), Label = "Plane", ValueLabel = "300" },
                new ChartEntry(300) { Color = SkiaSharp.SKColor.Parse("#8BC34A"), Label = "Plane", ValueLabel = "300" }
            };
            var donutChart = new DonutChart { Entries = entries };

            var chartView = new ChartView
            {
                Chart = donutChart,
                HeightRequest = 300,
                WidthRequest = 300,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromArgb("#9bd5d4")
            };

            grid.Children.Add(chartView);
            Grid.SetRow(chartView, 1);
        }

        private void AddReviewButton(Grid grid)
        {
            var reviewButton = new Button
            {
                Text = "Review expenses",
                HeightRequest = buttonSize,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            reviewButton.Pressed += OnButtonPressed;
            reviewButton.Released += OnButtonReleased;
            grid.Children.Add(reviewButton);
            Grid.SetRow(reviewButton, 2);
        }

        private void AddLabels(Grid grid)
        {
            var emissionsLabel = new Label
            {
                Text = "0.8 ton CO2\nRemaining emissions",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var offsetsLabel = new Label
            {
                Text = "2.0 ton CO2\nPurchased offsets",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var labelsStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            labelsStack.Children.Add(emissionsLabel);
            labelsStack.Children.Add(offsetsLabel);

            grid.Children.Add(labelsStack);
            Grid.SetRow(labelsStack, 3);
        }

        private void AddNavigationBar(Grid grid)
        {
            var bottomNavGrid = new Grid
            {
                ColumnDefinitions =
        {
            new ColumnDefinition { Width = GridLength.Star },
            new ColumnDefinition { Width = GridLength.Star },
            new ColumnDefinition { Width = GridLength.Star }
        }
            };

            var calculatorButton = CreateNavButton("calculator.svg");
            var reduceButton = CreateNavButton("reduce.svg");
            var offsetButton = CreateNavButton("offset.svg");

            // Add the buttons to the grid
            bottomNavGrid.Children.Add(calculatorButton);
            Grid.SetColumn(calculatorButton, 0); // Set the column after adding to grid

            bottomNavGrid.Children.Add(reduceButton);
            Grid.SetColumn(reduceButton, 1); // Set the column after adding to grid

            bottomNavGrid.Children.Add(offsetButton);
            Grid.SetColumn(offsetButton, 2); // Set the column after adding to grid

            grid.Children.Add(bottomNavGrid);
            Grid.SetRow(bottomNavGrid, 4);
        }

        private ImageButton CreateNavButton(string imageSource)
        {
            var button = new ImageButton
            {
                Source = imageSource,
                WidthRequest = buttonSize,
                HeightRequest = buttonSize,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            button.Pressed += OnButtonPressed;
            button.Released += OnButtonReleased;
            return button;
        }

        private async void OnButtonPressed(object? sender, EventArgs e)
        {
            if (sender is ImageButton button)
            {
                await button.ScaleTo(0.8, 50, Easing.CubicOut);
                Debug.WriteLine("Button Pressed: Animation to scale 0.8 completed");
            }
        }

        private async void OnButtonReleased(object? sender, EventArgs e)
        {
            if (sender is ImageButton button)
            {
                await button.ScaleTo(1.0, 50, Easing.CubicIn);
                Debug.WriteLine("Button Released: Animation to scale 1.0 completed");
            }
        }
    }
}
