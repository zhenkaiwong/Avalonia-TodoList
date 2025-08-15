using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoList.Models;

namespace TodoList.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<TodoItem> Items { get; } = new();
    [ObservableProperty] private string? _textboxValue;

    [RelayCommand]
    private void AddTextBoxValueToList()
    {
        if (string.IsNullOrEmpty(TextboxValue))
        {
            return;
        }
        
        Items.Add(new TodoItem(TextboxValue));
        TextboxValue = string.Empty;
    }
}