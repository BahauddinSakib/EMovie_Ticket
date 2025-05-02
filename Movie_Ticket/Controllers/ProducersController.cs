using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Ticket.Data;
using Movie_Ticket.Data.Services;

namespace Movie_Ticket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async  Task<IActionResult> Index()
        {
            var allProcedures = await _service.GetAllAsync();
            return View(allProcedures);
        }

        //Producers details

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }
    }
}
