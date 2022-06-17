using CascadingDropdownList.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CascadingDropdownList.Controllers
{
    public class CasecadeController : Controller
    {
        private readonly ApplicationContext context;
        public CasecadeController(ApplicationContext context)
        {
            this.context = context;
        }
        public JsonResult Country()
        {
            var cnt = context.Countries.ToList();
            return new JsonResult(cnt);
        }
        public JsonResult State(int id)
        {
            var st = context.States.Where(e => e.Country.Id == id).ToList();
            return new JsonResult(st);
        }
        public JsonResult City(int id)
        {
            var ct = context.Cities.Where(e=>e.State.Id == id).ToList();
            return new JsonResult(ct);
        }
        public ActionResult CasecadeDropdown()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
