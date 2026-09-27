using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Reviolet;

public partial class App : Application
{
    private Frontend _frontend;
    private Backend _backend;
    private Navigator _navigator;
    

    public App()
    {
        _frontend = new Frontend();
        _backend = new Backend();
        _navigator = new Navigator(_backend, _frontend);
    }


    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
           // delegate the creation of the main window to frontend
           _frontend.GenerateMainWindow(desktop);
        }

        base.OnFrameworkInitializationCompleted();
    }
}