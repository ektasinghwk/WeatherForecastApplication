using Microsoft.AspNetCore.Mvc;
using WeatherForecastApplication.Modals;

namespace WeatherForecastApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private static readonly List<string> TeamList = new List<string>
        {
        "Atul Dafle","Dhinesh K", "Ekta Singh", "Pranjal Madheshiya", "Suresh Kumaran", "Johnson Rajamani" 
       
        };

        private readonly ILogger<TeamController> _logger;

        public TeamController(ILogger<TeamController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTeamMembers")]
        public IActionResult Get()
        {
            ApiResponse response = ApiResponse.Success(TeamList);
            return Ok(response);
        }
    }
}