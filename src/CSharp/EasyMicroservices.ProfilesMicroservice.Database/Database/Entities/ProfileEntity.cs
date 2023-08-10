using EasyMicroservices.ProfileMicroservice.Database.Schemas;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfilesMicroservice.Database.Entities
{
    public class ProfileEntity : ProfileSchema, IIdSchema<long>
    {
        public long Id { get; set; }
    }
}
