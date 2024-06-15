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
        private string errorMessage;
        public CasesController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<ICountryRepository>();
            errorMessage = "Nie znaleziono danych o zachorowaniach.";
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_cases_before")]
        public IActionResult GetAllCasesBefore()
        {
            var response = repo.GetAllCasesBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
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
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_average_cases_before")]
        public IActionResult GetAverageCasesBefore()
        {
            var response = repo.GetAverageCasesBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_average_cases_after")]
        public IActionResult GetAverageCasesAfter()
        {
            var response = repo.GetAverageCasesAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }
    }
}
