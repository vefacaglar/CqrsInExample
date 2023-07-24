﻿using CqrsInExample.Infrastructure.GamesContext;
using CqrsInExample.Infrastructure.GamesContext.Abstractions;
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
            private readonly GamesDbContext _dbContext;

            public CreateGameCommandHandler(
                GamesDbContext dbContext
                )
            {
                _dbContext = dbContext;
            }
            public async Task<bool> Handle(CreateGameCommand request, CancellationToken cancellationToken)
            {
                
                return true;
            }
        }
    }
}
