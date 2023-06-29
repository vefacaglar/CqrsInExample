namespace CqrsInExample.Domain.Games.Request
{
    public class GameGenreRelationRequest
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }
    }
}
