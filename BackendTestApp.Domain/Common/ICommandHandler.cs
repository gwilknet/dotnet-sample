namespace BackendTestApp.Domain.Common;

public interface ICommandHandler<in TCommand, out TCommandResult>
{
    TCommandResult Execute(TCommand command);
}
