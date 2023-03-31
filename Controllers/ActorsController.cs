using eTickets.Data;
using eTickets.Data.Services;
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
	}
}
