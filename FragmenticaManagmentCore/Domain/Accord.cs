namespace FragmenticaManagmentCore.Domain;

public class Accord
{
    public string Name {get ; set; }
    public float Percentage { get; set; }
    public Accord(string name, float percentage)
    {
        Name = name;
        Percentage = percentage;
    }
}