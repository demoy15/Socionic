using System.ComponentModel.DataAnnotations;

namespace Socionic.Models;

public class SocionicTypes
{
    public Guid SocTypeId { get; }
    public string SocName { get; }
    public string Description { get; }
}