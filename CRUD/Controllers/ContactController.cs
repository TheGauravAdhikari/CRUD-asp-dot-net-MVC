using CRUD.Data;
using CRUD.Models;
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


        [HttpPost]

        public async Task<IActionResult> Create([Bind("Id,name,email,address,phone")] Contact Contact)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(Contact);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = "Data Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(Contact);
        }

    }
}
