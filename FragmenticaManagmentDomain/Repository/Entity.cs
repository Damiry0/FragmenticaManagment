using System.ComponentModel.DataAnnotations;

namespace FragmenticaManagmentCore.Repository;

public abstract class Entity
{
    [Key]
    public Guid Guid { get; init; }
}