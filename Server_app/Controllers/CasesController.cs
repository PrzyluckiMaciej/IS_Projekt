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
    public class CasesController : ControllerBase
    {
        private ICountryRepository repo;
        private MySqlConnection con;
        public CasesController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<ICountryRepository>();
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_cases_before")]
        public IActionResult GetAllCasesBefore()
        {
            var response = repo.GetAllCasesBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = "Nie znaleziono danych o zachorowaniach."
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_cases_after")]
        public IActionResult GetAllCasesAfter()
        {
            var response = repo.GetAllCasesAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = "Nie znaleziono danych o zachorowaniach."
                });
            return Ok(response);
        }
    }
}
