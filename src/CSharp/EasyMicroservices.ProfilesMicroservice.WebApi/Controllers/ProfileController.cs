using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ProfilesMicroservice.Contracts.Common;
using EasyMicroservices.ProfilesMicroservice.Contracts.Requests;
using EasyMicroservices.ProfilesMicroservice.Contracts.Responses;
using EasyMicroservices.ProfilesMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;

namespace EasyMicroservices.ProfilesMicroservice.WebApi.Controllers
{
    public class ProfileController : SimpleQueryServiceController<ProfileEntity, AddProfileRequestContract, UpdateProfileRequestContract, ProfileResponseContract, long>
    {
        public ProfileController(IContractLogic<ProfileEntity, AddProfileRequestContract, UpdateProfileRequestContract, ProfileResponseContract, long> contractReadable) : base(contractReadable)
        {
        }


    }
}
