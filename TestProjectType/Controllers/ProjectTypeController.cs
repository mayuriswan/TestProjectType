using Microsoft.AspNetCore.Mvc;
using TestProjectType.Models;
using TestProjectType.Services.Interface;

namespace TestProjectType.Controllers
{
    
        public class ProjectTypeController : Controller
        {
            private readonly IProjectTypeService _service;

            public ProjectTypeController(IProjectTypeService service)
            {
                _service = service;
            }

            public async Task<IActionResult> Index()
            {
                return View(await _service.GetAllAsync());
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(ProjectType projectType)
            {
                if (ModelState.IsValid)
                {
                    await _service.AddAsync(projectType);
                    return RedirectToAction(nameof(Index));
                }
                return View(projectType);
            }

            public async Task<IActionResult> Edit(int id)
            {
                var projectType = await _service.GetByIdAsync(id);
                if (projectType == null)
                {
                    return NotFound();
                }
                return View(projectType);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, ProjectType projectType)
            {
                if (id != projectType.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    await _service.UpdateAsync(projectType);
                    return RedirectToAction(nameof(Index));
                }
                return View(projectType);
            }

            public async Task<IActionResult> Delete(int id)
            {
                var projectType = await _service.GetByIdAsync(id);
                if (projectType == null)
                {
                    return NotFound();
                }
                return View(projectType);
            }

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                await _service.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
        }
    }
