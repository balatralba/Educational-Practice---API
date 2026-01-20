using EducationalPracticeAPI.Data;
using EducationalPracticeAPI.DTO;
using EducationalPracticeAPI.Models;
using EducationalPracticeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducationalPracticeAPI.Controllers
{
    [ApiController]
    [Route("api/group")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _service;

        public GroupController(IGroupService service, AppDbContext db)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetGroups()
        {
            List<GroupDto> result = await _service.GetAllGroups();
            return Ok(result);
        }
    }
}
