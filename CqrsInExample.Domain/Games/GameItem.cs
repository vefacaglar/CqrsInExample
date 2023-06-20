namespace CqrsInExample.Domain.Games
{
    public class GameItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Platforms { get; set; }
    }
}
