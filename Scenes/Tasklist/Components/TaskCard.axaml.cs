using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Reviolet.Models;

namespace Reviolet.Components;

public partial class TaskCard : UserControl
{
    private TasklistDependencies _deps;
    private IReadTask _task;
    
    public TaskCard(TasklistDependencies deps, IReadTask task)
    {
        InitializeComponent();

        // initialize deps and components
        _deps = deps;
        _task = task;

        // connect events for synchronization
        _deps.TaskService.ModifiedTasklistMember += RefreshDisplay;
        
        // set up UI elements
        RefreshDisplay();
    }


    // synchronizers {y}
    private void RefreshDisplay()
    {
        TaskDescription.Text = _task.Description;
    }
}