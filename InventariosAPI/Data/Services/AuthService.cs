using InventariosAPI.Data.Interfaces;
using InventariosAPI.Data.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace InventariosAPI.Data.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AuthResponse AuthorizeDefault(InfoConsumidor model)
        {
            //  [Pendiente] Simulacion de authenticacion verificando existencia de correo electrónico en IERP

            //var user = await _userManager.FindByEmailAsync(model.Email);
            ////FALTA VERIFICACIÓN PARA BLOQUEO TEMPORAL POR INTENTOS FALLIDOS.

            //if (user == null)
            //{
            //    return new UserManagerResponse
            //    {
            //        Message = "Intento de sesión Inválido",
            //        Code = Dictionary._LoginIsInvalid,
            //        IsSuccess = false
            //    };
            //}



            //Add default Role to generate a valid Token
            var claims = new[]
            {
                new Claim("Email", model.Email),
                new Claim("Password", model.Password),
                new Claim("AppName", model.AppName),
                new Claim("Plataform", model.Plataform),
                new Claim("RoleName", model.RoleName),
                new Claim("RoleId", model.RoleId.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Key"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["AuthSettings:Issuer"],
                audience: _configuration["AuthSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(model.TokenHours),               
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

            return new AuthResponse
            {
                Message = "OK",
                StatusCode = HttpStatusCode.OK,
                Token = tokenAsString,
                ExpireDate = token.ValidTo,
                Errors = new List<string>(),
                ExtraInfo = new List<string>()
            };
        }
    }
}
