using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfilesMicroservice.Contracts.Responses
{
    public class ProfileResponseContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
