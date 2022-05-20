using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverLetterReview.Data;

namespace CoverLetterReview.Contracts
{
    interface IDocumentFragmentRepository : IRepositoryBase<DocumentFragment>
    {
        public ICollection<DocumentFragment> GetAllFragmentsFromDocument(int DocumentID);

    }
}
