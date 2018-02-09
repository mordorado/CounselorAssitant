using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using CounselorAssistant.Models;
namespace CounselorAssistant.Models
{
    public class AssistantContext:DbContext
    {
        public AssistantContext(): base("name=Home")
        {
        }
        static AssistantContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AssistantContext, CounselorAssistant.Migrations.Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<User>()
            //    .HasRequired(p => p.People)
            //    .WithMany()
            //    .HasForeignKey(x => x.PeoID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Organization>()
            //    .HasRequired(p => p.Domain)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<House>()
            //    .HasRequired(p => p.Domain)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Request>()
            //    .HasRequired(p => p.User)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Request>()
            //    .HasRequired(p => p.Domain)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Domain> Domain { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Reservaion> Reservaion { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<FinancialDocument> FinancialDocument { get; set; }
    }

}
