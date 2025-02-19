using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using UserMicroservice.Authorization;
using UserMicroserviceBLL.DI;

namespace UserMicroservice.DI;

public static class ServicesConfiguration
{
    public static void AddApiDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddBusinessLogicDependencies(configuration);
        services.ConfigureSwagger();
        services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

        services.Configure<Auth0Settings>(configuration.GetSection(Auth0Settings.SectionName));
        services.AddAuth0Authentication();
    }

    private static void AddAuth0Authentication(this IServiceCollection services)
    {
        services.AddAuthentication(
            options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(
            options =>
            {
                var serviceProvider = services.BuildServiceProvider();
                var auth0Settings = serviceProvider.GetRequiredService<IOptions<Auth0Settings>>().Value;

                options.Authority = auth0Settings.Domain;
                options.Audience = auth0Settings.Audience;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = ClaimTypes.NameIdentifier
                };
            });

        services.AddAuthorizationBuilder()
            .AddPolicy(AuthorizationConstants.ReadUsersScope, policy =>
            {
                var serviceProvider = services.BuildServiceProvider();
                var auth0Settings = serviceProvider.GetRequiredService<IOptions<Auth0Settings>>().Value;

                policy.Requirements.Add(new HasScopeRequirement(AuthorizationConstants.ReadUsersScope, auth0Settings.Domain));
            });
    }
}
