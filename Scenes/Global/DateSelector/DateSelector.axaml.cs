using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Reviolet.Components;

public partial class DateSelector : UserControl
{
    public DateOnly Date { get; private set; }
    public string? DateName { get; set; }
    

    public DateSelector(string dateName = "")
    {
        InitializeComponent();
        Date = DateOnly.FromDateTime(DateTime.Now);
        DateName = dateName;

        // initialize components {white, 1}
        // (no deps for globals)

        // connect events for synchronization {white, 1}
        // ...
        
        // set up UI elements {white, 1}
        RefreshDisplay();
    }

    // relay methods {y}
    private void TriggerButton_Click(object? sender, RoutedEventArgs e)
    {
        Date = Date.AddDays(-1);
        RefreshDisplay();
    }

    private void TriggerButton_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        TriggerButton.Classes.Add("rightpressed");
        Date = Date.AddDays(1);
        RefreshDisplay();
    }

    private void TriggerButton_PointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        TriggerButton.Classes.Remove("rightpressed");
    }


    private void RefreshDisplay()
    {
        var dateStr = Date.ToString("ddd, dd MMM yyyy");
        TriggerButton.Content = $"{DateName}: {dateStr}";
        
    }
}