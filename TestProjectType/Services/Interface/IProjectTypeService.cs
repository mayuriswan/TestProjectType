using TestProjectType.Models;

namespace TestProjectType.Services.Interface
{
    public interface IProjectTypeService
    {
        Task<IEnumerable<ProjectType>> GetAllAsync();
        Task<ProjectType> GetByIdAsync(int id);
        Task AddAsync(ProjectType projectType);
        Task UpdateAsync(ProjectType projectType);
        Task DeleteAsync(int id);
    }
}
