using CqrsInExample.Infrastructure.GamesContext.Abstractions;

namespace CqrsInExample.Infrastructure.GamesContext;

public partial class GameGenreRelation : IEntity
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int GenreId { get; set; }
}
