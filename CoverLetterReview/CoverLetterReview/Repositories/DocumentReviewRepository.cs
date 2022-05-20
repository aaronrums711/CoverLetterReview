using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Contracts;
using CoverLetterReview.Data;

namespace CoverLetterReview.Repositories
{
    public class DocumentReviewRepository : IDocumentReviewRepository
    {
        private readonly ApplicationDbContext _db;
        public DocumentReviewRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(DocumentReview entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DocumentReview entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<DocumentReview> FindAll()
        {
            throw new NotImplementedException();
        }

        public DocumentReview FindByID(int ID)
        {
            throw new NotImplementedException();
        }

        public ICollection<DocumentReview> GetAllFeedback(int DocumentID)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(DocumentReview entity)
        {
            throw new NotImplementedException();
        }
    }
}
