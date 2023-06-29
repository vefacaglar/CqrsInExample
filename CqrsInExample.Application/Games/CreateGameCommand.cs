using CqrsInExample.Application.Abstractions;
using CSharpFunctionalExtensions;

namespace CqrsInExample.Domain.Games
{
    public sealed class CreateGameCommand : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public CreateGameCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [DatabaseRetry]
        internal sealed class CreateGameCommandHandler : ICommandHandler<CreateGameCommand>
        {

            public CreateGameCommandHandler(
                )
            {
            }

            public Result Handle(CreateGameCommand command)
            {
                return Result.Success();
            }
        }
    }
}
