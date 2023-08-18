namespace FragmenticaManagment.Models;

public class Perfume
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }
    public Enum Accords { get; set; }
    public float Rating { get; set; }
}