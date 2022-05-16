using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoverLetterReview.Data
{
    public class DocumentFragment
    {
        public int BaseDocumentID { get; set; }
        [Key]public int ID { get; set; }
        public string DocumentFragmentText { get; set; }
    }
}
