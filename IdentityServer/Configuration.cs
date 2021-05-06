using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> GetAPIs() =>
            new List<ApiScope> { 
                new ApiScope("ApiOne")
            };
        public static IEnumerable<ApiResource> GetAudAPIs() =>
            new List<ApiResource> { 
                new ApiResource("ApiOne")
                {
                    Scopes={"ApiOne"}
                }
            };
        public static IEnumerable<Client> GetClients() =>
            new List<Client>
            {
                new Client
                {
                    //these is needed to make sure
                    //that this client that request the access token
                    ClientId = "client_id",
                    ClientSecrets = {new Secret("client_secret".ToSha256())},
                    //flow of access token
                    AllowedGrantTypes ={GrantType.ClientCredentials},
                    AllowedScopes={ "ApiOne" }
                }
            };
    }
}
