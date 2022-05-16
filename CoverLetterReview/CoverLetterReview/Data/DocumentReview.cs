using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoverLetterReview.Data
{
    public class DocumentReview
    {
        public int BaseDocumentID { get; set; }
        [Key]public int ID { get; set; }
        public int DocumentFragmentID { get; set; }
        public string ReviewCommentText { get; set; }
        public enum _CommentType { positive, constructive, neutral };
        public _CommentType CommentType;
    }
}
