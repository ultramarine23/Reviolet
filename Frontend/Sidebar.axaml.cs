using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Reviolet.Views;

public partial class SidebarView : UserControl
{
    private INavigation _navigator;
    private Button[] _navButtons;
    
    public SidebarView(INavigation navigator)
    {
        InitializeComponent();

        _navigator = navigator;
        _navigator.SceneChanged += OnSceneChanged;

        // for new scenes: add here
        _navButtons = [TasklistButton, SettingsButton];
    }


    private void OnSceneChanged(SceneName newScene)
    {
        // enable all buttons to reset
        Array.ForEach(_navButtons, b => b.IsEnabled = true);
        
        switch (newScene)
        {
            // for new scenes: add here
            case SceneName.TASKLIST:
                TasklistButton.IsEnabled = false;
                break;
            case SceneName.SETTINGS:
                SettingsButton.IsEnabled = false;
                break;
        }
    }


    // event receiver methods {y}
    // for new scenes: add here
    private void TasklistButton_Click(object? sender, RoutedEventArgs e)
    {
        _navigator.NavigateToScene(SceneName.TASKLIST);
    }

    private void SettingsButton_Click(object? sender, RoutedEventArgs e)
    {
        _navigator.NavigateToScene(SceneName.SETTINGS);
    }

}