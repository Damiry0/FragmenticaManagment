

namespace FragmenticaManagmentCore.Domain;

public class Accord : ValueObject
{
    public string Name { get; private set; }
    public float Percentage { get; private set; }
    public Accord(string name, float percentage)
    {
        Name = name;
        Percentage = percentage;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Percentage;
    }
}