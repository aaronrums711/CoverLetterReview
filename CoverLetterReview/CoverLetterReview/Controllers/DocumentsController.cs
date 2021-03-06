using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoverLetterReview.Data;
using Microsoft.AspNetCore.Identity;
using CoverLetterReview.ViewModels;

namespace CoverLetterReview.Controllers
{
    public class DocumentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public DocumentsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Documents
        public async Task<IActionResult> AdminIndex()
        {
            List<AdminListDocumentVM> objects = new List<AdminListDocumentVM>();

            foreach (Document doc in _context.Document)
            {
                AdminListDocumentVM docVM = new AdminListDocumentVM();
                switch (doc.Priority)
                {
                    case 1:
                        docVM.PriorityDescription = "Low";
                            break;
                    case 2:
                        docVM.PriorityDescription = "Medium";
                        break;
                    case 3:
                        docVM.PriorityDescription = "High";
                        break;
                }
                IdentityUser user = _context.Users.FirstOrDefault(q => q.Id == doc.SubmittedByUserID);
                docVM.SubmittedByUserName = (user == null) ? "Unknown" : user.UserName;
                docVM.IntendedJob = doc.IntendedJob;
                docVM.SubmittedDateTime = doc.SubmittedDateTime;
                docVM.DocumentName = doc.DocumentName;
                docVM.DocumentTextFirst30 = doc.DocumentTextFirst30;
                docVM.ID = doc.ID;
                if (!doc.ReviewCompleted)
                {
                    if(doc.ReviewStartedDateTime == null)
                    {
                        docVM.ReviewStatus = "Not Started";
                    }
                    else if (doc.ReviewStartedDateTime != null)
                    {
                        docVM.ReviewStatus = "In Progress";
                    }
                }
                else
                {
                    docVM.ReviewStatus = "Finished";
                }
                objects.Add(docVM);
            }

            return View(objects);
        }

        public IActionResult UserIndex()
        {
            string userID = _userManager.GetUserAsync(User).Result.Id;
            List<Document> documents = _context.Document.Where(q => q.SubmittedByUserID == userID).ToList();

            return View(documents);
        }


        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document
                .FirstOrDefaultAsync(m => m.ID == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // GET: Documents/Create
        public IActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Document document)
        {
            Document newDoc = document;
            newDoc.DocumentTextFirst30 = newDoc.DocumentText.Substring(0, 30) + "...";
            newDoc.SubmittedByUserID = _userManager.GetUserAsync(User).Result.Id;   //I don't fully understand how User is succesfully passed in here
            if (ModelState.IsValid)
            {
                _context.Add(newDoc);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserIndex");  //only users will ever create documents, so there's no need to do any logic to determine if a user or admin is logged in
            }
            return RedirectToAction("UserIndex");
        }

        // GET: Documents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return View(document);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Priority,DocumentName,DocumentText,SubmittedDateTime,IntendedJob,SubmittedByUserID,ID,ReviewCompleted")] Document document)
        {
            if (id != document.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(document);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentExists(document.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(document);
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document
                .FirstOrDefaultAsync(m => m.ID == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var document = await _context.Document.FindAsync(id);
            _context.Document.Remove(document);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentExists(int id)
        {
            return _context.Document.Any(e => e.ID == id);
        }
    }
}
