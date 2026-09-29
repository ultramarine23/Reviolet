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
    
    public DateSelector()
    {
        InitializeComponent();
        Date = DateOnly.FromDateTime(DateTime.Now);

        // initialize components {white, 1}
        // (no deps for globals)

        // connect events for synchronization {white, 1}
        // ...
        
        // set up UI elements {white, 2}
        RefreshDisplay();
        SetIsHoldingEnabled(this, false);
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
        TriggerButton.Content = Date.ToString("ddd, dd MMM yyyy");
    }
}