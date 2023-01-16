namespace BackendTestApp.Domain.Commands;

public class CreateWorkoutCommandResult
{
    public Guid NewId { get; set; }
}

public class CreateWorkoutCommand
{
    public string? Name { get; set; }
}
