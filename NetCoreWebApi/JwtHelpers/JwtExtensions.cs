using System;
using Wasalee.DTOs;
using Microsoft.Extensions.Configuration;

namespace Wasalee.JwtHelpers
{
    public static class JwtExtensions
    {   
        public static void GenerateToken(this UserDTO user, IConfiguration configuration)
        {
            try
            {
                var token = new JwtTokenBuilder()
                                .AddSecurityKey(JwtSecurityKey.Create(configuration.GetValue<string>("JwtSecretKey")))
                                .AddIssuer(configuration.GetValue<string>("JwtIssuer"))
                                .AddAudience(configuration.GetValue<string>("JwtAudience"))
                                .AddExpiry(30)
                                .AddClaim("Id", user.Id.ToString())
                                .AddRole("User")
                                .Build();

                user.Token = token.Value;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
