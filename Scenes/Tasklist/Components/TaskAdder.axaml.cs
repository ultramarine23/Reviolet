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
    
    public TaskAdder(TasklistDependencies deps)
    {
        InitializeComponent();

        // initialize deps and components
        _deps = deps;

        // connect events for synchronization
        // ...
        
        // set up UI elements
        // ...
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