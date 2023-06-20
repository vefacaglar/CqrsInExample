namespace CqrsInExample.Domain.Request
{
    public class GameGenreRelationRequest
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }
    }
}
