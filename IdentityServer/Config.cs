﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {

        public static IEnumerable<ApiResource> ApiResources => new ApiResource[] {
        new ApiResource("resource_catalog"){ Scopes={ "catalog_fullpermission" } },
        new ApiResource("resource_photo_stock"){ Scopes={ "photo_stock_fullpermission" } },
        new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("catalog_fullpermission","katalog api için tam erişim"),
                new ApiScope("photo_stock_fullpermission","photo stock api için tam erişim"),
                new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName="Asp.Net Core MVC",
                    ClientId="WebMvcClient",
                    ClientSecrets={ new Secret("secret".Sha256())},
                    AllowedGrantTypes={GrantType.ClientCredentials },
                    AllowedScopes={ "catalog_fullpermission",
                                    "photo_stock_fullpermission",
                                    IdentityServerConstants.LocalApi.ScopeName }
                }

            };
    }
}






// m2m client credentials flow client
//new Client
//{
//    ClientId = "m2m.client",
//    ClientName = "Client Credentials Client",

//    AllowedGrantTypes = GrantTypes.ClientCredentials,
//    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

//    AllowedScopes = { "scope1" }
//},

//// interactive client using code flow + pkce
//new Client
//{
//    ClientId = "interactive",
//    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

//    AllowedGrantTypes = GrantTypes.Code,

//    RedirectUris = { "https://localhost:44300/signin-oidc" },
//    FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
//    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

//    AllowOfflineAccess = true,
//    AllowedScopes = { "openid", "profile", "scope2" }
//},