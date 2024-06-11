using Microsoft.EntityFrameworkCore;
using TestProjectType.DAL.Interface;
using TestProjectType.Data;
using TestProjectType.Models;

namespace TestProjectType.DAL.Implementation
{
    public class ProjectTypeRepository : IProjectTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProjectType>> GetAllAsync()
        {
            return await _context.ProjectTypes.ToListAsync();
        }

        public async Task<ProjectType> GetByIdAsync(int id)
        {
            return await _context.ProjectTypes.FindAsync(id);
        }

        public async Task AddAsync(ProjectType projectType)
        {
            _context.ProjectTypes.Add(projectType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProjectType projectType)
        {
            _context.Entry(projectType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var projectType = await _context.ProjectTypes.FindAsync(id);
            if (projectType != null)
            {
                _context.ProjectTypes.Remove(projectType);
                await _context.SaveChangesAsync();
            }
        }
    }
}
