﻿using Insight.Database;
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

        [HttpGet("getCasesBefore")]
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

        [HttpGet("getCasesAfter")]
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
