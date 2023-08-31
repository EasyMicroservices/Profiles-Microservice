using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfilesMicroservice.Contracts.Requests
{
    public class UpdateProfileRequestContract : AddProfileRequestContract
    {
        public long Id { get; set; }
    }
}
