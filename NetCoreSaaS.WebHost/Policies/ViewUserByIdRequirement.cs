﻿using Microsoft.AspNetCore.Authorization;
using NetCoreSaaS.Core;
using NetCoreSaaS.WebHost.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCoreSaaS.WebHost.Policies
{
        public class ViewUserByIdRequirement : IAuthorizationRequirement
        {

        }


        public class ViewUserByIdHandler : AuthorizationHandler<ViewUserByIdRequirement, string>
        {
            protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ViewUserByIdRequirement requirement, string targetUserId)
            {
                if (context.User.HasClaim(CustomClaimTypes.Permission, ApplicationPermissions.ViewUsers) || GetIsSameUser(context.User, targetUserId))
                    context.Succeed(requirement);

                return Task.CompletedTask;
            }


            private bool GetIsSameUser(ClaimsPrincipal user, string targetUserId)
            {
                return Utilities.GetUserId(user) == targetUserId;
            }
        }
}
