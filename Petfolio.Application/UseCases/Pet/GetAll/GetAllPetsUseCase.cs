using Petfolio.Comunication.Enums;
using Petfolio.Comunication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets =
            [
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Charlie",
                    Type = PetType.Dog
                }
            ]
        };
    }
}
