namespace BackendTestApp.Domain.Model;

public record Workout
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}
