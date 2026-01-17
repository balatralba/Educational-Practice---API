using EducationalPracticeAPI.DTO;

namespace EducationalPracticeAPI.Services
{
    public interface IGroupService
    {
        Task<List<GroupDto>> GetAllGroups();
    }
}
