using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Contracts;
using CoverLetterReview.Data;

namespace CoverLetterReview.Repositories 
{
    public class DocumentFragmentRepository : IDocumentFragmentRepository
    {

        private readonly ApplicationDbContext _db;
        public DocumentFragmentRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(DocumentFragment entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DocumentFragment entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<DocumentFragment> FindAll()
        {
            throw new NotImplementedException();
        }

        public DocumentFragment FindByID(int ID)
        {
            throw new NotImplementedException();
        }

        public ICollection<DocumentFragment> GetAllFragmentsFromDocument(int DocumentID)
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

        public bool Update(DocumentFragment entity)
        {
            throw new NotImplementedException();
        }
    }
}
