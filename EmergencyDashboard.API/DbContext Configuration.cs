using Microsoft.EntityFrameworkCore;

public class EmergencyDashboardDbContext : DbContext
{
    public DbSet<Ambulance> Ambulances { get; set; }
    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<EmergencyAlert> EmergencyAlerts { get; set; }

    public EmergencyDashboardDbContext(DbContextOptions<EmergencyDashboardDbContext> options)
        : base(options)
    {
    }
}
