// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Client.Controllers
{
    public class AuthenticationController : Controller
    {
        [Authorize]
        public async Task Logout()
        {
            //Clears the local cache
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            //redirect to the IDP linked to the Scheme
            //"OpenIdConnectDefaults.AuthenticationScheme" (oidc)
            //so it can clear its own session/cookie
            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}
