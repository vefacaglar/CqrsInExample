using Microsoft.EntityFrameworkCore;

namespace CqrsInExample.Persistence.GamesContext;

public partial class GamesDbContext : DbContext
{
    public GamesDbContext()
    {
    }

    public GamesDbContext(DbContextOptions<GamesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameGenreRelation> GameGenreRelations { get; set; }

    public virtual DbSet<GamePlatformRelation> GamePlatformRelations { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Platform> Platforms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Games__3214EC07A784CEA6");

            entity.Property(e => e.Cover)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.DeletionTime).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<GameGenreRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GameGenr__3214EC074848EB5E");

            entity.ToTable("GameGenreRelation");
        });

        modelBuilder.Entity<GamePlatformRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GamePlat__3214EC07E353074D");

            entity.ToTable("GamePlatformRelation");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Genres__3214EC079DFD6CC5");

            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.DeletionTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Platform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Platform__3214EC072CAFB237");

            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.DeletionTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
