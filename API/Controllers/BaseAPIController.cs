using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    // Attribute of a controller
    [ApiController]
    // This is a placeholder, effectively taking the name of the class and removing
    // `Controller` and using the name as the endpoint.
    // Hence the endpoint to this controller is /WeatherForecast
    [Route("/api/[controller]")]
    public class BaseAPIController : ControllerBase
    {
        
    }
}