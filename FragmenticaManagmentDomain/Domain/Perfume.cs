using ClassLibrary1.Domain.Enums;
using FluentValidation;
using FragmenticaManagmentCore.Repository;

namespace FragmenticaManagmentCore.Domain;

public class Perfume : Entity
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }
    public float Rating { get; set; }
    public Gender Gender { get; set; }
    public int beka { get; set; }
    
    private readonly List<Accord> _accords = new();
    public IReadOnlyCollection<Accord> Accords => _accords.AsReadOnly();
    
    public Perfume()
    {
        Ulid = Ulid.NewUlid();
        Validate(this);
    }

    private static void Validate(Perfume perfume)
    {
        var validator = new PerfumeValidator();

        var results = validator.Validate(perfume);

        if (results.IsValid) return;
        foreach(var failure in results.Errors)
        {
           throw new ValidationException(failure.ErrorMessage);
        }
    }
    
    private sealed class PerfumeValidator : AbstractValidator<Perfume>
    {
        public PerfumeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("Brand is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Accords).NotEmpty().WithMessage("Accords is required");
            RuleFor(x => x.Rating).NotEmpty().WithMessage("Rating is required");
        }
    }
}