using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Reviolet.Views;

public partial class SidebarView : UserControl
{
    private INavigation _navigator;
    
    public SidebarView(INavigation navigator)
    {
        InitializeComponent();

        _navigator = navigator;
    }


    // event receiver methods {y}
    private void TasklistButton_Click(object? sender, RoutedEventArgs e)
    {
        _navigator.NavigateToScene(SceneName.TASKLIST);
    }

    private void SettingsButton_Click(object? sender, RoutedEventArgs e)
    {
        _navigator.NavigateToScene(SceneName.SETTINGS);
    }

}