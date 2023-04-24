using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
			_service = service;
        }
        public async Task<IActionResult> Index()
		{
			var actors = await _service.GetAll();
			return View(actors);
		}
		
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create([Bind("FullName, ProfilePictureURL, Bii")]Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			_service.Add(actor);
			return RedirectToAction(nameof(System.Index));
		}
		
		//Get: Actors/Details/{id}
		public async Task<IActionResult> Details(int id)
		{
			var actor = await _service.GetByIdAsync(id);
			if (actor == null) return View("NotFound");
			return View(actor);
		}

		public async Task<IActionResult> Edit(int id)
		{
			var actor = await _service.GetByIdAsync(id);
			return View(actor);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, Actor actor)
		{
			if (!ModelState.IsValid) return View(actor);
			
			await _service.UpdateAsync(id, actor);
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Delete(int id)
		{
			var actor = await _service.GetByIdAsync(id);
			if (actor == null) return View("NotFound");

			return View(actor);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var actorToDelete = await _service.GetByIdAsync(id);
			if (actorToDelete == null) return View("NotFound");
			
			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
		
		
	}
}
