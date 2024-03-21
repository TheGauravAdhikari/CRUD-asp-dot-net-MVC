using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace dotnetCRUD.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactDbContext _dbContext;

        public ContactController(ContactDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Contacts.ToListAsync());
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




        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carLeadEntity = await _dbContext.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carLeadEntity == null)
            {
                return NotFound();
            }

            return View(carLeadEntity);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carLeadEntity = await _dbContext.Contacts.FindAsync(id);
            if (carLeadEntity != null)
            {
                _dbContext.Contacts.Remove(carLeadEntity);
            }

            await _dbContext.SaveChangesAsync();
            TempData["success"] = "Data Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
