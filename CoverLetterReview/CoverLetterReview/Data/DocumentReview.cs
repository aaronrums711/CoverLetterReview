using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoverLetterReview.Data
{
    /// <summary>
    /// one DocumentReview item is one piece of feedback regarding a particular document.  Sometimes the DocumentFragmentID 
    /// can be null if the feedback regards the entire document, not any particular part. 
    /// </summary>
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
