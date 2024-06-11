using TestProjectType.Models;

namespace TestProjectType.DAL.Interface
{
    public interface IProjectTypeRepository
    {
        Task<IEnumerable<ProjectType>> GetAllAsync();
        Task<ProjectType> GetByIdAsync(int id);
        Task AddAsync(ProjectType projectType);
        Task UpdateAsync(ProjectType projectType);
        Task DeleteAsync(int id);
    }
}
