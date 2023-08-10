using EasyMicroservices.ProfilesMicroservice.Helpers;
using EasyMicroservices.ProfilesMicroservice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfilesMicroservice
{
    public class StartUp
    {
        public Task Run(IDependencyManager dependencyManager)
        {
            ApplicationManager.Instance.DependencyManager = dependencyManager;
            return Task.CompletedTask;
        }
    }
}
