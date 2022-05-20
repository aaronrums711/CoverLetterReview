using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoverLetterReview.Data
{
    /// <summary>
    /// a DocumentFragment is one sentence in a Document.  This class makes it easier to associate a particular piece of feedback with a particular sentence 
    /// in a Document.  
    /// </summary>
    public class DocumentFragment
    {
        public int BaseDocumentID { get; set; }
        [Key]public int ID { get; set; }
        public string DocumentFragmentText { get; set; }
    }
}
