using CSharpFunctionalExtensions;

namespace CqrsInExample.Application.Abstractions
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}
