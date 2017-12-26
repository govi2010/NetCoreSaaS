using Microsoft.AspNetCore.Authorization;
using NetCoreSaaS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreSaaS.WebHost.Policies
{
    public class ViewRoleByNameRequirement : IAuthorizationRequirement
    {

    }


    public class ViewRoleByNameHandler : AuthorizationHandler<ViewRoleByNameRequirement, string>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ViewRoleByNameRequirement requirement, string roleName)
        {
            if (context.User.HasClaim(CustomClaimTypes.Permission, ApplicationPermissions.ViewRoles) || context.User.IsInRole(roleName))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
