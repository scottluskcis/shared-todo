using System;

namespace Shared.Models.Todo;

public class TodoItem
{
    public long Id { get; set; } = 0;
    public string Title { get; set; } = "Todo Item";
    public string? Description { get; set; }
    public DateTime? DateCreated { get; set; }
    public string? CreatedBy { get; set; }
} 