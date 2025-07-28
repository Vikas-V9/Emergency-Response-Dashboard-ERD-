using Microsoft.EntityFrameworkCore;

// Define the Ambulance class if it does not exist
public class Ambulance
{
    public int Id { get; set; }
    // Add other properties as needed
}

// Define the Hospital class
public class Hospital
{
    public int Id { get; set; }
    // Add other properties as needed
}

// Define the EmergencyAlert class
public class EmergencyAlert
{
    public int Id { get; set; }
    // Add other properties as needed
}

public class ApplicationDbContext : DbContext
{
    public DbSet<Ambulance> Ambulances { get; set; }
    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<EmergencyAlert> EmergencyAlerts { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}