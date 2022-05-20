using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Data;

namespace CoverLetterReview.Contracts
{
    interface IDocumentRepository : IRepositoryBase<Document>
    {
        public ICollection<Document> GetAllDocsFromUser(string UserID);

    }
}
