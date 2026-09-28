using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Reviolet.Components;

public partial class KanbanBoard : UserControl
{
    private KanbanColumn _backlogColumn;
    private KanbanColumn _progressColumn;
    private KanbanColumn _completedColumn;

    public KanbanBoard()
    {
        InitializeComponent();

        _backlogColumn = new("Backlog");
        _progressColumn = new("In-Progress");
        _completedColumn = new("Completed");  

        BacklogColumnSlot.Content = _backlogColumn;
        ProgressColumnSlot.Content = _progressColumn;
        CompletedColumnSlot.Content = _completedColumn;      
    }
}