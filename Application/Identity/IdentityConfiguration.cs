using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Security.Claims;
using Test.Application.Controllers;

namespace Test.Application.Identity
{
    public class IdentityConfiguration
    {
        private readonly ILogger<IdentityConfiguration> _logger;

        public IdentityConfiguration(ILogger<IdentityConfiguration> logger)
        {
            _logger = logger;
        }

        public static List<TestUser> TestUsers =>
            new List<TestUser>
        
            {
            
                new TestUser
               
             {
                     SubjectId = "1144",
                     Username = "ahmed",
                     Password = "ahmed",
                     Claims =
                     {
                            new Claim(JwtClaimTypes.Name, "ahmed mohamed"),
                            new Claim(JwtClaimTypes.GivenName, "ahmed"),
                            new Claim(JwtClaimTypes.FamilyName, "refaay"),
                            new Claim(JwtClaimTypes.WebSite, "//codewithmukesh.com"),
                     }
               
             }
    
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
    new IdentityResource[]
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
        
     
    };

        public static IEnumerable<ApiScope> ApiScopes =>
    new ApiScope[]
    {
        new ApiScope("myApi.read"),
        new ApiScope("myApi.write"),
    };

        public static IEnumerable<ApiResource> ApiResources =>
    new ApiResource[]
    {
        new ApiResource("myApi")
        {
            Scopes = new List<string>{ "myApi.read","myApi.write" },
            ApiSecrets = new List<Secret>{ new Secret("supersecret".Sha256()) }
        }
    };

        public static IEnumerable<Client> Clients =>
    new Client[]
    {
        new Client
        {
            ClientId = "clinet_mobile",
            ClientName = "Client Credentials Client",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = { new Secret("secret".Sha256()) },
            AllowedScopes = { "myApi.read" },
            Enabled=true
        },
    };
    }
}
