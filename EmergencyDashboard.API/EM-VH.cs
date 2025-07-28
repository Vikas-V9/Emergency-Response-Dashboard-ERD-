public class EmergencyVehicle
{
    public int Id { get; set; }
    public required string VehicleType { get; set; }
    public required string VehicleNumber { get; set; }
    public string? DriverName { get; set; }
    public bool IsAvailable { get; set; }
    public double CurrentLat { get; set; }
    public double CurrentLng { get; set; }
    public int? AssignedHospitalId { get; set; }
}
