using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ProfilesMicroservice.Contracts.Common;
using EasyMicroservices.ProfilesMicroservice.Contracts.Requests;
using EasyMicroservices.ProfilesMicroservice.Contracts.Responses;
using EasyMicroservices.ProfilesMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using Storage.GeneratedServices;

namespace EasyMicroservices.ProfilesMicroservice.WebApi.Controllers
{
    public class ProfileController : SimpleQueryServiceController<ProfileEntity, AddProfileRequestContract, UpdateProfileRequestContract, ProfileResponseContract, long>
    {
        private IConfiguration _config;
        private string _storageRoot;
        private FileClient _storageClient;
        public ProfileController(IContractLogic<ProfileEntity, AddProfileRequestContract, UpdateProfileRequestContract, ProfileResponseContract, long> contractReadable, IConfiguration config) : base(contractReadable)
        {
            _config = config;
            _storageRoot = _config.GetValue<string>("RootAddresses:storage");
            _storageClient = new(_storageRoot, new HttpClient());
        }


        public async override Task<MessageContract<long>> Add(AddProfileRequestContract request, CancellationToken cancellationToken = default)
        {
            if (request.File == null)
                return (ServiceContracts.FailedReasonType.Incorrect, "File must'nt be empty.");

            var addProfileResponse = await base.Add(request, cancellationToken);
            if (!addProfileResponse.IsSuccess)
                return addProfileResponse;

            var getProfileResponse = await base.GetById(addProfileResponse.Result);
            if (!getProfileResponse.IsSuccess)
                return getProfileResponse.ToContract<long>();

            var fileResult = await _storageClient.UploadFileAsync(
                file: new FileParameter(
                    request.File.OpenReadStream(),
                    request.File.FileName,
                    request.File.ContentType
                    ),
                folderId: 1,
                uniqueIdentity: getProfileResponse.Result.UniqueIdentity,
                cancellationToken: cancellationToken
            );

            if (!fileResult.IsSuccess)
                return fileResult.ToContract<long>();



            return addProfileResponse.Result;
        }

        public async override Task<MessageContract<ProfileResponseContract>> Update(UpdateProfileRequestContract request, CancellationToken cancellationToken = default)
        {
            var updateResponse = await base.Update(request, cancellationToken);
  
            if (updateResponse.IsSuccess && request.File != null)
            {
                var fileResult = await _storageClient.UploadFileAsync(
                    file: new FileParameter(
                        request.File.OpenReadStream(),
                        request.File.FileName,
                        request.File.ContentType
                        ),
                    folderId: 1,
                    uniqueIdentity: updateResponse.Result.UniqueIdentity,
                    cancellationToken: cancellationToken
                );
                if (!fileResult.IsSuccess)
                    return fileResult.ToContract<ProfileResponseContract>();
            }

            return updateResponse;
        }
    }
}
