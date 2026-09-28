using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Reviolet.Components;

public partial class KanbanColumn : UserControl
{
    private List<TaskCard> _taskCards;
    
    // constructors {o}    
    public KanbanColumn(string colName)
    {
        InitializeComponent();

        _taskCards = new();

        Header.Text = colName;
    }



}