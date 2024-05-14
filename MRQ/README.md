# .NET MAUI Project

This is a .NET Multi-platform App UI (MAUI) project built for Android, iOS, and Windows platforms. The application aims to provide a user-friendly interface for tracking emissions, calculating offsets, and visualizing data through interactive charts.

## Tech Stack

- **.NET MAUI**: A cross-platform framework for building native mobile and desktop applications using C# and XAML.
- **C#**: The programming language used for implementing the application logic.
- **XAML**: The markup language used for defining the user interface.
- **Microcharts**: A modern, cross-platform charting library for .NET MAUI and other .NET platforms.
- **SkiaSharp**: A cross-platform 2D graphics library for rendering vector graphics, bitmaps, and PDFs.

## Progress

### Current Progress: UI Implementation

The project is currently in the UI implementation phase, focusing on creating an intuitive and visually appealing user interface. The main page features:

- A settings icon in the top-right corner.
- A donut chart in the center, displaying dummy data for now.
- A "Review Expenses" button below the chart.
- Labels showing the remaining emissions and purchased offsets.
- A bottom navigation bar with icons for the Calculator, Reduce, and Offset pages.

Here's a code snippet from the `MainPage.xaml.cs` file, demonstrating the UI construction:

```csharp
private void BuildUI()
{
    var grid = new Grid
    {
        // Grid row and column definitions
        // ...
    };

    AddSettingsIcon(grid);
    AddDonutChart(grid);
    AddReviewButton(grid);
    AddLabels(grid);
    AddNavigationBar(grid);

    Content = grid;
}

### Next Steps: Charting and Data Visualization
The next phase of the project will focus on integrating the Microcharts library for creating interactive and visually appealing data visualizations. This will involve:

Fetching and processing data from various sources (e.g., emissions data, expenses, calculations).
Implementing custom chart types and configurations to effectively represent the data.
Enabling user interactions with the charts, such as tooltips, zooming, and filtering.

Contributing
If you'd like to contribute to this project, please follow these steps:

Fork the repository
Create a new branch (git checkout -b feature/your-feature-name)
Make your changes and commit them (git commit -am 'Add some feature')
Push to the branch (git push origin feature/your-feature-name)
Create a new Pull Request

License
This project is licensed under the MIT License.