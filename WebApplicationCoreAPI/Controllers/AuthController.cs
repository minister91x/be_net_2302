using DataAccess.DenpencyInjection.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("Authen")]
        public async Task<string> Authen(AccountAuthenRequestData requestData)
        {
            try
            {
                // gọi login thành công lấy thông tin user 
                //CÁCH 1: ADONET +DAPPER + STOREPROCEDURE 
                //CÁCH 2: SỬ DỤNG ENTITIES +IDENTITY 

                await Task.Yield();
                var authClaims = new List<Claim> {
                    new Claim(ClaimTypes.Name, requestData.UserName),
                    new Claim(ClaimTypes.NameIdentifier, requestData.Password),
                      new Claim(ClaimTypes.Email, "quannt@gmail.com"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), };

                var jwtSecurityToken = CreateToken(authClaims);
                //Sau khi tạo được token thì phải lưu TokenExpired
                return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPost("RefreshToken")]
        public async Task<IActionResult> RefreshToken(string accessToken)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtSecurityToken = handler.ReadJwtToken(accessToken);
                var CandidateEmail = jwtSecurityToken.Claims.First(claim => claim.Type == "Email").Value;

                // gọi vaò database lấy thời gian hết hạn của tokn
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

            private JwtSecurityToken CreateToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            _ = int.TryParse(_configuration["JWT:TokenValidityInMinutes"], out int tokenValidityInMinutes);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(tokenValidityInMinutes),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

    }
}
