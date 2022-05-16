using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoverLetterReview.Data
{

    /// <summary>
    /// this class represents one document uploaded by a user.  An admin will be able to see all documents by all users, 
    /// but a regular user will only be able to see the list of documents that they have personally uploaded for review. 
    /// </summary>
    public class Document
    {
        private int priority;

        public int Priority
        {
            get { return priority; }
            set
            {
                if (value <= 1)
                {
                    priority = 1;
                }
                else if (value >= 3)
                {
                    priority = 3;
                }
            }
        }

        public string DocumentName { get; set; }
        public string DocumentText { get; set; }
        public DateTime SubmittedDateTime { get; set; }
        public string IntendedJob { get; set; }
        public string SubmittedByUserID { get; set; }
        [Key] public int ID { get; set; }
        public bool ReviewCompleted { get; set; }
    }
}
