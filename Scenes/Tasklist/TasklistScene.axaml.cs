using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Reviolet.Components;

namespace Reviolet.Scenes;

public partial class TasklistScene : SceneControl
{
    // scene components {r}
    private KanbanBoard _kanbanBoard;

    
    public TasklistScene()
    {
        InitializeComponent();

        _kanbanBoard = new();

        KanbanBoardSlot.Content = _kanbanBoard;
    }
}