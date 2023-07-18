using Exam_ASPNETMVC.Entity;
using Exam_ASPNETMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Exam_ASPNETMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;
        public ContactController(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
               
                _context.Contacts.Add(new Contacts
                {
                    Contact_Name = viewModel.Contact_Name,
                    Contact_Number = viewModel.Contact_Number,
                    Group_Name = viewModel.Group_Name,
                    Hire_Date = viewModel.Hire_Date,
                    Birthday = viewModel.Birthday,

                });
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            return View(viewModel);
        }
        public IActionResult List()
        {
            var contacts = _context.Contacts.OrderByDescending( c => c.Contact_Name ).ToList<Contacts>();
            return View(contacts);
        }
        [HttpPost]
        public IActionResult List(string Search)
        {
            if (Search == null)
            {
                return RedirectToAction("List");
            }
            var contacts = _context.Contacts.Where(c => c.Contact_Name.Contains(Search) || c.Group_Name.Contains(Search)).ToList();
            return View(contacts);
        }
    }
}
