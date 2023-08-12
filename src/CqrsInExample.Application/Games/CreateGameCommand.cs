using CqrsInExample.Infrastructure;
using CqrsInExample.Infrastructure.GamesContext;
using MediatR;

namespace CqrsInExample.Domain.Games
{
    public sealed class CreateGameCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public CreateGameCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }

        internal sealed class CreateGameCommandHandler : IRequestHandler<CreateGameCommand, bool>
        {
            private readonly IUnitOfWork _uow;

            public CreateGameCommandHandler(
                IUnitOfWork _unitOfWork
                )
            {
                _uow = _unitOfWork;
            }

            public async Task<bool> Handle(CreateGameCommand request, CancellationToken cancellationToken)
            {
                var newGame = new Game()
                {
                    Name = request.Name,
                    Description = request.Description,
                    CreationTime = DateTime.Now,
                };

                var repository = _uow.GetRepository<Game>();

                repository.Add(newGame);

                await _uow.SaveChangesAsync();

                return true;
            }
        }
    }
}
