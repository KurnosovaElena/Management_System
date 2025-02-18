using Microsoft.AspNetCore.Authorization;

namespace UserMicroservice.Authorization;

public class HasScopeHandler : AuthorizationHandler<HasScopeRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasScopeRequirement requirement)
    {
        var scopeClaim = context.User.FindFirst(c => c.Type == AuthorizationConstants.ScopeClaimType && c.Issuer == requirement.Issuer);

        if (scopeClaim == null || string.IsNullOrEmpty(scopeClaim.Value))
            return Task.CompletedTask;

        var scopes = scopeClaim.Value.Split(' ');

        if (scopes.Any(s => s == requirement.Scope))
            context.Succeed(requirement);

        return Task.CompletedTask;
    }
}
