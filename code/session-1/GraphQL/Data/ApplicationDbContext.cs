namespace ConferencePlanner.GraphQL.Data;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Attendee>()
            .HasIndex(a => a.UserName)
            .IsUnique();

        // Many-to-many: Session <-> Attendee
        modelBuilder
            .Entity<SessionAttendee>()
            .HasKey(ca => new { ca.SessionId, ca.AttendeeId });

        // Many-to-many: Speaker <-> Session
        modelBuilder
            .Entity<SessionSpeaker>()
            .HasKey(ss => new { ss.SessionId, ss.SpeakerId });
    }

    public DbSet<Session> Sessions => this.Set<Session>();

    public DbSet<Track> Tracks => this.Set<Track>();

    public DbSet<Speaker> Speakers => this.Set<Speaker>();

    public DbSet<Attendee> Attendees => this.Set<Attendee>();
}