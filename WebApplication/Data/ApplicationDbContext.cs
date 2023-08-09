using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpenSourceSCORMLMS.Data.ModelSCORM;
using System.Linq;
using System.Reflection.Emit;

namespace OpenSourceSCORMLMS.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
             
        }
       
        public DbSet<cmi_core> cmi_core { get; set; }
        public DbSet<cmi_data> cmi_data { get; set; }
        public DbSet<cmi_comment_from_learner> cmi_comment_from_learner { get; set; }
        public DbSet<cmi_comment_from_lms> cmi_comment_from_lms { get; set; }
        public DbSet<cmi_interactions> cmi_interactions { get; set; }
        public DbSet<cmi_interactions_correct_responses> cmi_interactions_correct_responses { get; set; }
        public DbSet<cmi_interactions_objectives> cmi_interactions_objectives { get; set; }
        public DbSet<cmi_objectives> cmi_objectives { get; set; }
        public DbSet<cmi_student_preference> cmi_student_preferences { get; set; }
        public DbSet<SCORM_Course> SCORM_Course { get; set; }
        public DbSet<session> session { get; set; }
        public DbSet<User_Module> User_Module { get; set; }

        public DbSet<SCORM_Course_fromSP> SCORM_Course_FromSP { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<SCORM_Course_fromSP>().HasNoKey();
        }
    }   
    
}
