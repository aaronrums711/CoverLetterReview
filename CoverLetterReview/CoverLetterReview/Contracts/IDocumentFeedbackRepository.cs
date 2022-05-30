using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Data;

namespace CoverLetterReview.Contracts
{
    interface IDocumentFeedbackRepository : IRepositoryBase<DocumentFeedback>
    {
        public ICollection<DocumentFeedback> GetAllFeedback(int DocumentID);
    }
}
