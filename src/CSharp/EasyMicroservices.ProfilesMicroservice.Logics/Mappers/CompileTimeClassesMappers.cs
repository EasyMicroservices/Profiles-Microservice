//using System.Threading.Tasks;
//using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
//using EasyMicroservices.Mapper.Interfaces;
//using System.Linq;

//namespace CompileTimeMapper
//{
//    public class ProfileEntity_ProfileContract_Mapper : IMapper
//    {
//        readonly IMapperProvider _mapper;
//        public ProfileEntity_ProfileContract_Mapper(IMapperProvider mapper)
//        {
//            _mapper = mapper;
//        }
//        public global::EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity Map(global::EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity()
//            {
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModifiationDateTime = fromObject.ModifiationDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity,
//            };
//            return mapped;
//        }
//        public global::EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract Map(global::EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract()
//            {
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModifiationDateTime = fromObject.ModifiationDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity,


//            };
//            return mapped;
//        }
//        public async Task<global::EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity> MapAsync(global::EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity()
//            {
//                Id = fromObject.Id,
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModifiationDateTime = fromObject.ModifiationDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity,


//            };
//            return mapped;
//        }
//        public async Task<global::EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract> MapAsync(global::EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract()
//            {
//                Id = fromObject.Id,
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModifiationDateTime = fromObject.ModifiationDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity,

//            };
//            return mapped;
//        }
//        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            if (fromObject.GetType() == typeof(EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity))
//                return Map((EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity)fromObject, uniqueRecordId, language, parameters);
//            return Map((EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract)fromObject, uniqueRecordId, language, parameters);
//        }
//        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            if (fromObject.GetType() == typeof(EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity))
//                return await MapAsync((EasyMicroservices.ProfilesMicroservice.Database.Entities.ProfileEntity)fromObject, uniqueRecordId, language, parameters);
//            return await MapAsync((EasyMicroservices.ProfilesMicroservice.Contracts.Common.ProfileContract)fromObject, uniqueRecordId, language, parameters);
//        }
//    }
//}