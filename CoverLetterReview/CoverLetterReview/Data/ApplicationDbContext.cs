using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CoverLetterReview.Data;

namespace CoverLetterReview.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentFragment> DocumentFragment { get; set; }
        public DbSet<DocumentFeedback> DocumentReview  { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)  //this is necessary because the DocumentFeedback class was originally named DocumentReview.  
        {
            base.OnModelCreating(builder);
            builder.Entity<DocumentFeedback>().ToTable("DocumentFeedback");
        }

    }
}
