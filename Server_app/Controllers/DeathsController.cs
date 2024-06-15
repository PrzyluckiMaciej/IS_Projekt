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
        private string errorMessage;
        public DeathsController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<ICountryRepository>();
            errorMessage = "Nie znaleziono danych o śmierciach.";
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_deaths_before")]
        public IActionResult GetAllDeathsBefore()
        {
            IList<Entities.CountrySet> response = repo.GetAllDeathsBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_deaths_after")]
        public IActionResult GetAllDeathsAfter()
        {
            IList<Entities.CountrySet> response = repo.GetAllDeathsAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_average_deaths_before")]
        public IActionResult GetAverageDeathsBefore()
        {
            IList<Entities.AverageCountryData> response = repo.GetAverageDeathsBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_average_deaths_after")]
        public IActionResult GetAverageDeathsAfter()
        {
            IList<Entities.AverageCountryData> response = repo.GetAverageDeathsAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }
    }
}
