using Microsoft.AspNetCore.Mvc;

namespace cis237_assignment_6.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactAction()
        {
            return Content("This is the contact route.");
        }
    }
}
