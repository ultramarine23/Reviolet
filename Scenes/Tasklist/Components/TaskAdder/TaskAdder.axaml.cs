using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Reviolet.Models;

namespace Reviolet.Components;

public partial class TaskAdder : UserControl
{
    private TasklistDependencies _deps;
    
    private DateSelector _dateSelector;
    
    public TaskAdder(TasklistDependencies deps)
    {
        InitializeComponent();

        // initialize deps and components
        _deps = deps;
        _dateSelector = new DateSelector();

        // connect events for synchronization
        // ...
        
        // set up UI elements
        DateSelectorSlot.Content = _dateSelector;
    }

    // relay methods
    public void AdderButton_Click(object? sender, RoutedEventArgs e)
    {
        var newDetails = new TaskDetails(
            isImportant:false,
            description:"Foo bar.",
            dateDue:DateTime.Now,
            dateCreated:DateTime.Now,
            estimatedTime:TimeSpan.FromHours(5)
        );
        
        _deps.TaskService.AddTask(new Task(newDetails));
    }
}