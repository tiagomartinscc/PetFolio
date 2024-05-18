using Petfolio.Comunication.Enums;

namespace Petfolio.Comunication.Responses;

public class ResponsePetJon
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime Birthday { get; set; }

    public PetType Type { get; set; }
}
