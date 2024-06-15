using Insight.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Server_app.Entities;
using Server_app.Services.DB_data;

namespace Server_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private IExamRepository repo;
        private MySqlConnection con;
        public ExamsController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<IExamRepository>();
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_exams_before")]
        public IActionResult GetAllExamResultsBefore()
        {
            var response = repo.GetAllExamResultsBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = "Nie znaleziono danych o egzaminach."
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_exams_after")]
        public IActionResult GetAllExamResultsAfter()
        {
            var response = repo.GetAllExamResultsAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = "Nie znaleziono danych o egzaminach."
                });
            return Ok(response);
        }
    }
}
