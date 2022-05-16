﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoverLetterReview.Data
{
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
