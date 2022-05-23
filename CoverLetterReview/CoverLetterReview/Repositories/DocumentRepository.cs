using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Contracts;
using CoverLetterReview.Data;

namespace CoverLetterReview.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {

        private readonly ApplicationDbContext _db;
        public DocumentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Document entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Document entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Document> FindAll()
        {
            throw new NotImplementedException();
        }

        public Document FindByID(int ID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Document> GetAllDocsFromUser(string UserID)
        {
            throw new NotImplementedException();
        }

        public string GetFirstNumChar(string documentText, int charCount = 30)
        {
            return documentText.Substring(0, charCount);
        }

        public bool isExists(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Document entity)
        {
            throw new NotImplementedException();
        }
    }
}
