using System;
using System.Collections.Generic;

namespace CqrsInExample.Data.GamesContext;

public partial class GamePlatformRelation
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int PlatformId { get; set; }
}
