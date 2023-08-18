using FluentValidation;

namespace FragmenticaManagmentCore;

public class Perfume
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }
    public Enum Accords { get; set; }
    public float Rating { get; set; }
    
    public Perfume()
    {
        Id = Guid.NewGuid();
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
    
    private class PerfumeValidator : AbstractValidator<Perfume>
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