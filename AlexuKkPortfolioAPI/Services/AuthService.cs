using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;



namespace AlexuKkPortfolioAPI.Services
{
    public class AuthService(AppDBContext context, IConfiguration configuration) : IAuthService
    {
        public async Task<string> Login(LoginDTO dto)
        {
            var user = await context.Users
                .FirstOrDefaultAsync(u => u.Username.ToLower() == dto.Username.ToLower());

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            if (!VerifyPasswordHash(dto.Password, user.PasswordHash, user.PasswordSalt))
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            return CreateToken(user); 
        }

        public async Task<User> Register(LoginDTO dto) 
        {

            if (await UserExists(dto.Username))
            {
                throw new Exception("User already exists.");
            }

            byte[] passwordHash;
            byte[] passwordSalt;

            CreatePasswordHash(dto.Password, out passwordHash, out passwordSalt);


            var newUser = new User
            {
                Username = dto.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = "Admin"   
            };

            context.Users.Add(newUser);
            await context.SaveChangesAsync();

            return newUser;
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {

                passwordSalt = hmac.Key;

                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private async Task<bool> UserExists(string username)
        {
            return await context.Users
                .AnyAsync(u => u.Username.ToLower() == username.ToLower());
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(User user)
        {
           
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Name, user.Username),
        new Claim(ClaimTypes.Role, user.Role)
    };


            var key = new SymmetricSecurityKey(
                System.Text.Encoding.UTF8.GetBytes(
                    configuration.GetSection("AppSettings:TokenSecret").Value
                    ?? throw new InvalidOperationException("JWT Secret Key not found in configuration.")
                )
            );


            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1), 
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}
