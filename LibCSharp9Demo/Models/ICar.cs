namespace LibCSharp9Demo.Models
{
    public interface IVehicle
    {
        string Brand { get; init; }
        string TypeName { get; init; }
        int Year { get; init; }
        string Color { get; set; }
    }
}
