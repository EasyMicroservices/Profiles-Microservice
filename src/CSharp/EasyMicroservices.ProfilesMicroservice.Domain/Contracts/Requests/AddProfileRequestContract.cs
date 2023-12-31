﻿using EasyMicroservices.Cores.Interfaces;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EasyMicroservices.ProfilesMicroservice.Contracts.Requests
{
    public class AddProfileRequestContract : IUniqueIdentitySchema
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
