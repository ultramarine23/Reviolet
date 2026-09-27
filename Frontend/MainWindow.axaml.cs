using Avalonia.Controls;
using Reviolet.Views;

namespace Reviolet;

public partial class MainWindow : Window
{
    // Component views {r}
    public SidebarView Sidebar { get; }
    public IScene PresentedScene { get; private set; }


    public MainWindow(IScene initialScene)
    {
        InitializeComponent();

        PresentedScene = initialScene;
        Sidebar = new SidebarView();

        SidebarSlot.Content = Sidebar;
        SceneSlot.Content = PresentedScene;
    }
}