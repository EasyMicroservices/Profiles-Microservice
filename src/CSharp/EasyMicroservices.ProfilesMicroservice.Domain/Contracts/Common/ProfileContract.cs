using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfilesMicroservice.Contracts.Common
{
    public class ProfileContract : IUniqueIdentitySchema
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
