using CqrsInExample.Domain.Games;
using CqrsInExample.Domain.Games.Response;
using CqrsInExample.Infrastructure.Repositories.Abstractions;
using MediatR;

namespace CqrsInExample.Application.Games
{
    public sealed class GetGamesQuery : IRequest<GetGamesResponse>
    {
        public GetGamesQuery()
        {
            
        }

        internal sealed class GetGamesQueryHandler : IRequestHandler<GetGamesQuery, GetGamesResponse>
        {
            private readonly IGamesRepository _gamesRepository;

            public GetGamesQueryHandler(
                IGamesRepository gamesRepository
                )
            {
                _gamesRepository = gamesRepository;
            }

            public async Task<GetGamesResponse> Handle(GetGamesQuery request, CancellationToken cancellationToken)
            {
                var games = await _gamesRepository.GetGamesAsync();

                return new GetGamesResponse
                {
                    Games = games.ToList(),
                };
            }
        }
    }
}
