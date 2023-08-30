using CodeReviewer.Engine;
using EasyMicroservices.ProfilesMicroservice.Contracts.Common;
using EasyMicroservices.ProfilesMicroservice.Database.Entities;
using EasyMicroservices.ProfilesMicroservice.Helpers;
using EasyMicroservices.ProfilesMicroservice.WebApi.Controllers;
using EasyMicroservices.Tests;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.IO;
using System.Linq;

namespace EasyMicroservices.ProfilesMicroservice.Tests
{
    public class CodeReviewerCheckTests : CodeReviewerTests
    {
        static CodeReviewerCheckTests()
        {
            //types to check (this will check all of types in assembly so no need to add all of types of assembly)
            AssemblyManager.AddAssemblyToReview(
                typeof(ApplicationManager),
                typeof(StartUp),
                typeof(ProfileEntity),
                typeof(ProfileContract),
                typeof(ProfileController));
        }
    }
}