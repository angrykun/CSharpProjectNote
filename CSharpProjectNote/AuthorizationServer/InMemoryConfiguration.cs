using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.Extensions.Configuration;

namespace AuthorizationServer
{
    public class InMemoryConfiguration
    {
        public static IConfiguration Configuration { get; set; }

        /// <summary>
        /// Defined which APIs will use this IdentityServer
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
              new ApiResource("clientservice","CAS Client Server")
              {
                  Scopes = new List<string>(){ "clientservice" }
              },
              new ApiResource("productservice","CAS Product Server"),
              new ApiResource("agentservice","CAS AgentServer")
            };
        }

        /// <summary>
        /// Defined which Apps will use this IdentityServer
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                new Client
                {
                    ClientId = "client.api.service",
                    ClientSecrets = new[] {new Secret("clientsecret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new[] {"clientserver"},
                    AllowOfflineAccess = true
                },
                new Client
                {
                    ClientId = "product.api.service",
                    ClientSecrets = new[] {new Secret("productsecret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new[] { "productserver" },
                    AllowOfflineAccess = true
                },
                new Client
                {
                    ClientId = "agent.api.service",
                    ClientSecrets = new[] {new Secret("agentsecret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new[] {"clientserver","productservice","agentservice"},
                    AllowOfflineAccess = true
                }
            };
        }

        /// <summary>
        /// Defined which users will use this IdentityServer
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<TestUser> GetUsers()
        {
            return new[]
            {
                new TestUser
                {
                    SubjectId = "10001",
                    Username = "angrykun@google.com",
                    Password = "angrykunpassword"
                },
                new TestUser
                {
                    SubjectId = "10002",
                    Username = "andy@google.com",
                    Password = "andypassword"
                },   new TestUser
                {
                    SubjectId = "10003",
                    Username = "leo@google.com",
                    Password = "leopassword"
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("clientservice")

            };
        }

    }
}