using CqrsInExample.Infrastructure.GamesContext.Abstractions;

namespace CqrsInExample.Infrastructure.GamesContext;

public partial class GamePlatformRelation : IEntity
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int PlatformId { get; set; }
}
