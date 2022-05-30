using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Contracts;
using CoverLetterReview.Data;

namespace CoverLetterReview.Repositories
{
    public class DocumentFeedbackRepository : IDocumentFeedbackRepository
    {
        private readonly ApplicationDbContext _db;
        public DocumentFeedbackRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(DocumentFeedback entity)
        {
            _db.DocumentReview.Add(entity);
            return Save();
        }

        public bool Delete(DocumentFeedback entity)
        {
            _db.Remove(entity);
            return Save();
        }

        public ICollection<DocumentFeedback> FindAll()
        {
            return _db.DocumentReview.ToList();
        }

        public DocumentFeedback FindByID(int ID)
        {
            DocumentFeedback review = _db.DocumentReview.FirstOrDefault(q => q.ID == ID);
            return review;
        }

        public ICollection<DocumentFeedback> GetAllFeedback(int DocumentID)
        {
            ICollection<DocumentFeedback> allFeeback = _db.DocumentReview.Where(q => q.BaseDocumentID == DocumentID).ToList();
            return allFeeback;
        }

        public bool isExists(int ID)
        {
            bool exists = _db.DocumentReview.Any(q => q.ID == ID);
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;  //mouse over SaveChanges() to see that it returns an int for how many records are changed
        }

        public bool Update(DocumentFeedback entity)
        {
            _db.DocumentReview.Update(entity);
            return Save();
        }
    }
}
