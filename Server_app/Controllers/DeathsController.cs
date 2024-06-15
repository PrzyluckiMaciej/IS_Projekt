using Insight.Database;
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

        [HttpGet("getDeathsBefore")]
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

        [HttpGet("getDeathsAfter")]
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
