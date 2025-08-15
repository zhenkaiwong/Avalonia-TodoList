using System;

namespace TodoList.Models;

public class TodoItem(string description)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Description { get; init; } = description;
    public bool IsDone { get; set; } 

}