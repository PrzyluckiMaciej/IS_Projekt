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
        private string errorMessage;
        public ExamsController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<IExamRepository>();
            errorMessage = "Nie znaleziono danych o egzaminach.";
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_exams_before")]
        public IActionResult GetAllExamResultsBefore()
        {
            var response = repo.GetAllExamResultsBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
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
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_average_exams_before")]
        public IActionResult GetAverageExamPerYearBefore()
        {
            var response = repo.GetAverageExamPerYearBefore();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "read", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get_average_exams_after")]
        public IActionResult GetAverageExamPerYearAfter()
        {
            var response = repo.GetAverageExamPerYearAfter();
            if (response == null)
                return BadRequest(new
                {
                    message = errorMessage
                });
            return Ok(response);
        }

        [Authorize(Roles = "write", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("clear_before")]
        public IActionResult ClearExamsBefore()
        {
            repo.ClearExamsBefore();
            return Ok();
        }

        [Authorize(Roles = "write", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("insert_before")]
        public IActionResult InsertExamsBefore(ExamResult result)
        {
            repo.InsertExamsBefore(result);
            return Ok();
        }

        [Authorize(Roles = "write", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("clear_after")]
        public IActionResult ClearExamsAfter()
        {
            repo.ClearExamsAfter();
            return Ok();
        }

        [Authorize(Roles = "write", AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("insert_after")]
        public IActionResult InsertExamsAfter(ExamResult result)
        {
            repo.InsertExamsAfter(result);
            return Ok();
        }
    }
}
