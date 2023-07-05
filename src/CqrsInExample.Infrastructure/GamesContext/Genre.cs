using CqrsInExample.Infrastructure.GamesContext.Abstractions;

namespace CqrsInExample.Infrastructure.GamesContext;

public partial class Genre : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime? DeletionTime { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? ModifiedTime { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
