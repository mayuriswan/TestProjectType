using TestProjectType.DAL.Interface;
using TestProjectType.Models;
using TestProjectType.Services.Interface;

namespace TestProjectType.Services.Implementation
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly IProjectTypeRepository _repository;

        public ProjectTypeService(IProjectTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProjectType>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ProjectType> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(ProjectType projectType)
        {
            await _repository.AddAsync(projectType);
        }

        public async Task UpdateAsync(ProjectType projectType)
        {
            await _repository.UpdateAsync(projectType);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
