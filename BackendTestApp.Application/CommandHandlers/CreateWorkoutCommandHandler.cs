using BackendTestApp.Domain.Commands;
using BackendTestApp.Domain.Common;

namespace BackendTestApp.Application.CommandHandlers;

internal class CreateWorkoutCommandHandler : ICommandHandler<CreateWorkoutCommand, CreateWorkoutCommandResult>
{
    public CreateWorkoutCommandResult Execute(CreateWorkoutCommand command)
    {
        // saving workout


        return new CreateWorkoutCommandResult
        {
            NewId = Guid.NewGuid()
        };
    }
}
