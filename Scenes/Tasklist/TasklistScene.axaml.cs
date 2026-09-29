using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Reviolet.Components;

namespace Reviolet.Scenes;

public partial class TasklistScene : SceneControl
{
    private TasklistDependencies _deps;
    
    // scene components {r}
    private KanbanBoard _kanbanBoard;
    private TaskAdder _taskAdder;

    
    public TasklistScene(TasklistDependencies deps)
    {
        InitializeComponent();

        _deps = deps;
        _kanbanBoard = new(_deps);
        _taskAdder = new(_deps);

        KanbanBoardSlot.Content = _kanbanBoard;
        TaskAdderSlot.Content = _taskAdder;
    }
}