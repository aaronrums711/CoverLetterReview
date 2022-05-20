using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Data;

namespace CoverLetterReview.Contracts
{
    interface IDocumentReviewRepository : IRepositoryBase<DocumentReview>
    {
        public ICollection<DocumentReview> GetAllFeedback(int DocumentID);
    }
}
