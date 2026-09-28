using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Reviolet.Components;

public partial class KanbanBoard : UserControl
{
    private TasklistDependencies _deps;

    private KanbanColumn _backlogColumn;
    private KanbanColumn _progressColumn;
    private KanbanColumn _completedColumn;

    public KanbanBoard(TasklistDependencies deps)
    {
        InitializeComponent();

        _deps = deps;

        _backlogColumn = new(_deps, "Backlog");
        _progressColumn = new(_deps, "In-Progress");
        _completedColumn = new(_deps, "Completed");  

        BacklogColumnSlot.Content = _backlogColumn;
        ProgressColumnSlot.Content = _progressColumn;
        CompletedColumnSlot.Content = _completedColumn;      
    }
}