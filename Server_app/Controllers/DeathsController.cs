using Insight.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Server_app.Services.DB_data;

namespace Server_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeathsController : ControllerBase
    {
        private ICountryRepository repo;
        private MySqlConnection con;
        public DeathsController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<ICountryRepository>();
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_deaths_before")]
        public IActionResult GetAllDeathsBefore()
        {
            var response = repo.GetAllDeathsBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = "Nie znaleziono danych o śmierciach."
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_deaths_after")]
        public IActionResult GetAllDeathsAfter()
        {
            var response = repo.GetAllDeathsAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = "Nie znaleziono danych o śmierciach."
                });
            return Ok(response);
        }
    }
}
