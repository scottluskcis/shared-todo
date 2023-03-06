using System;

namespace Shared.Models.Todo;

public class TodoAssignment
{
  public long AssignmentId { get; set; } = 0;
  public long TodoId { get; set; } = 0;  
  public long GroupId { get; set; } = 0;
} 