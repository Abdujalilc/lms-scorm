using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpenSourceSCORMLMS.Data.ModelSCORM;

namespace OpenSourceSCORMLMS.Data
{
    // this extends the auto-generated ApplicationDbContext with a custom Class for a Query Type
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public DbQuery<SCORM_Course_fromSP> SCORM_Course_FromSP { get; set; }
    }
}
