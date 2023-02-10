// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Frittes.IDP;

public class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {

            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "95ffa54a-8dbb-4e10-bb82-80814f9ab846",
                    Username = "David",
                    Password = "password",
                    Claims =
                    {
                        new Claim("role", "FreeUser"),
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                    }
                },
                new TestUser
                {
                    SubjectId = "ae6764c7-c012-496d-92b6-0e2f70635c38",
                    Username = "Emma",
                    Password = "password",
                    Claims =
                    {
                        new Claim("role", "PayingUser"),
                        new Claim(JwtClaimTypes.GivenName, "Emma"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                    }
                }
            };
        }
    }
}
