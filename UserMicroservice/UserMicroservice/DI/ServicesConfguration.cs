using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using UserMicroservice.Authorization;
using UserMicroserviceBLL.DI;

namespace UserMicroservice.DI;

public static class ServicesConfguration
{
    public static void AddApiDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddBusinessLogicDependencies(configuration);
        services.ConfigureSwagger();
        services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
        services.AddAuth0Authentication(configuration);
    }

    private static void AddAuth0Authentication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(
    options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(
    options =>
    {
        options.Authority = configuration["Auth0:Domain"];
        options.Audience = configuration["Auth0:Audience"];
        options.TokenValidationParameters = new TokenValidationParameters
        {
            NameClaimType = ClaimTypes.NameIdentifier
        };
    });

        services.AddAuthorizationBuilder()
           .AddPolicy("read:users", policy => policy.Requirements.Add(new
            HasScopeRequirement("read:users", configuration["Auth0:Domain"])));
    }
}
