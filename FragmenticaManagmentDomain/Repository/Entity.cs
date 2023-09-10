using System.ComponentModel.DataAnnotations;

namespace FragmenticaManagmentCore.Repository;

public abstract class Entity
{
    [Key]
    public Ulid Ulid { get; protected init; }
}