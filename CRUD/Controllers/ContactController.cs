using CRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetCRUD.Controllers
{
    public class ContactController : Controller
    {
        public readonly ContactDbContext _dbContext;
        public ContactController(ContactDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var list = _dbContext.Contacts.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
