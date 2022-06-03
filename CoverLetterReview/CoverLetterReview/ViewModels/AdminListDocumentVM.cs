using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CoverLetterReview.ViewModels
{
    public class AdminListDocumentVM
    {
        public string PriorityDescription { get; set; }

        [Display(Name = "Document Name")]
        public string DocumentName { get; set; }

        [Display(Name = "First Lines")]
        public string DocumentTextFirst30 { get; set; }

        [Display(Name = "Date Submitted")]
        public DateTime SubmittedDateTime { get; set; }

        [Display(Name = "Desired Job")]
        public string IntendedJob { get; set; }

        [Display(Name = "Submitted By")]
        public string SubmittedByUserName { get; set; }

        [Display(Name = "Review Status")]
        public string ReviewStatus;

        public int ID { get; set; }
    }
}
