using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ProfilesMicroservice.Contracts.Common;
using EasyMicroservices.ProfilesMicroservice.Database.Entities;

namespace EasyMicroservices.ProfilesMicroservice.WebApi.Controllers
{
    public class ProfileController : SimpleQueryServiceController<ProfileEntity, ProfileContract, ProfileContract, ProfileContract, long>
    {
        public ProfileController(IContractLogic<ProfileEntity, ProfileContract, ProfileContract, ProfileContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}
