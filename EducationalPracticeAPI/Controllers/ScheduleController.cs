using EducationalPracticeAPI.Data;
using EducationalPracticeAPI.Models;
using EducationalPracticeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducationalPracticeAPI.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;
        public ScheduleController(IScheduleService service, AppDbContext db)
        {
            _service = service;
        }
    }
}
