using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfileMicroservice.Database.Schemas
{
    public class ProfileSchema : IUniqueIdentitySchema
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime ModifiationDateTime { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
