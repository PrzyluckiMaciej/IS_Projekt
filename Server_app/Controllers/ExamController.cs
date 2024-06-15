using Insight.Database;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Server_app.Entities;
using Server_app.Services.DB_data;

namespace Server_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private IExamRepository repo;
        private MySqlConnection con;
        public ExamController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<IExamRepository>();
        }

        [HttpGet("getExamsBefore")]
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

        [HttpGet("getExamsAfter")]
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
