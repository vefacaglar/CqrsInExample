using System;
using System.Collections.Generic;

namespace CqrsInExample.Persistence.GamesContext;

public partial class GamePlatformRelation
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int PlatformId { get; set; }
}
