using Avalonia.Controls;
using Reviolet.Views;

namespace Reviolet;

public partial class MainWindow : Window
{
    // Component views {r}
    public SidebarView Sidebar { get; }
    public SceneControl? PresentedScene { get; private set; }


    public MainWindow(SidebarView sidebar, SceneControl initScene)
    {
        InitializeComponent();

        Sidebar = sidebar;
        PresentedScene = initScene;

        SidebarSlot.Content = Sidebar;
        SceneSlot.Content = PresentedScene;
    }


    public void SwitchScene(SceneControl newScene)
    {
        PresentedScene = newScene;
        SceneSlot.Content = PresentedScene;
    }
}