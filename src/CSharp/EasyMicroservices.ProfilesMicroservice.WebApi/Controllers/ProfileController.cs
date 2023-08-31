using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ProfilesMicroservice.Contracts.Common;
using EasyMicroservices.ProfilesMicroservice.Contracts.Requests;
using EasyMicroservices.ProfilesMicroservice.Contracts.Responses;
using EasyMicroservices.ProfilesMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;

namespace EasyMicroservices.ProfilesMicroservice.WebApi.Controllers
{
    public class ProfileController : SimpleQueryServiceController<ProfileEntity, ProfileContract, ProfileContract, ProfileResponseContract, long>
    {
        public ProfileController(IContractLogic<ProfileEntity, ProfileContract, ProfileContract, ProfileResponseContract, long> contractReadable) : base(contractReadable)
        {
        }


    }
}
