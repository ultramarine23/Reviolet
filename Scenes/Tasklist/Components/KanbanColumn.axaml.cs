using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Reviolet.Models;

namespace Reviolet.Components;

public partial class KanbanColumn : UserControl
{
    private TasklistDependencies _deps;
    
    private ObservableCollection<TaskCard> _taskCards = [];
    
    // constructors {o}    
    public KanbanColumn(TasklistDependencies deps, string colName)
    {
        InitializeComponent();

        // initialize deps and components
        _deps = deps;

        // set up UI elements
        Header.Text = colName;
        TaskCardsSlot.ItemsSource = _taskCards;

        // connect events for synchronization
        _deps.TaskService.ModifiedTasklist += RefreshDisplay;
        RefreshDisplay();
    }


    // synchronizers {y}
    private void RefreshDisplay()
    {
        _taskCards.Clear();

        foreach (var task in _deps.StateQuery.GetTasks())
        {
            _taskCards.Add(new TaskCard(_deps, task));
        }
    }

}