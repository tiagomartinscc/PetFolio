using Petfolio.Comunication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{

    public ResponsePetJon Execute(int id)
    {
        return new ResponsePetJon
        {
            Id = id,
            Name = "Pipoca",
            Birthday = new DateTime(year: 2023, month: 01, day: 10),
            Type = Comunication.Enums.PetType.Cat
        };
    }
}
