using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace App1
{
    static class Config
    {


        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
            new ApiResource("app2api", "My API")
            };
        }


        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }


        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
                {
                new Client
                {
                    ClientId = "js",
                    ClientName = "JavaScript Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = false,
                    RequireConsent = true,
                    RequireClientSecret = false,
                    RedirectUris =           {"com.googleusercontent.apps.932931520457-buv2dnhgo7jjjjv5fckqltn367psbrlb:/auth", "http://localhost:5003/callback.html" },
                    PostLogoutRedirectUris = { "com.googleusercontent.apps.932931520457-buv2dnhgo7jjjjv5fckqltn367psbrlb:/auth","http://localhost:5003/index.html" },
                    AllowOfflineAccess = true,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "app2api"
                    },
                    AccessTokenType = AccessTokenType.Jwt

                },
 
            };
        }
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
             new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "password",
                    Claims = new []
                    {
                        new Claim("name", "Alice"),
                        new Claim("website", "https://alice.com")
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "password",
                    Claims = new []
                    {
                        new Claim("name", "Bob"),
                        new Claim("website", "https://bob.com")
                    }
                }
            };
        }

    }
}