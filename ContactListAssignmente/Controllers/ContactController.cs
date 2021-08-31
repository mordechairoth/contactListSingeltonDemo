using ContactListAssignmente.Models;
using ContactListAssignmente.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListAssignmente.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactsHandler _contactsHandler;
        public ContactController()
        {
            _contactsHandler = ContactsHandler.GetInstance();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            _contactsHandler.Add(contact);

            return RedirectToAction(nameof(List));
        }

        //this should've used the httpDelete method but uses get method instead, so that it should be able to be used as an href without js
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _contactsHandler.Remove(id);

            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.ContactId = id;

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            _contactsHandler.Edit(contact);
            
            return RedirectToAction(nameof(List)); 
        }
    }
}
