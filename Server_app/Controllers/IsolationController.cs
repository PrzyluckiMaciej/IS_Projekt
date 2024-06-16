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
    public class IsolationController : ControllerBase
    {
        private IIsolationService repo;
        private MySqlConnection con;
        public IsolationController()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;");
            repo = con.As<IIsolationService>();
        }

        [HttpPost("set")]
        public IActionResult SetIsolationLevel()
        {
            repo.SetIsolationLevel();
            return Ok();
        }
    }
}
