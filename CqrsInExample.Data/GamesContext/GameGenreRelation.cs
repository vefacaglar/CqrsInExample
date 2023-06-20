namespace CqrsInExample.Data.GamesContext;

public partial class GameGenreRelation
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int GenreId { get; set; }
}
