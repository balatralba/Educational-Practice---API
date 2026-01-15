using EducationalPracticeAPI.DTO;

namespace EducationalPracticeAPI.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime startDate, DateTime endDate);
    }
}
