using Petfolio.Comunication.Requests;
using Petfolio.Comunication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;

public class RegisterPetUseCase
{
    public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson
        { 
            Id = 1,
            Name = request.Name
        };
    }
}
