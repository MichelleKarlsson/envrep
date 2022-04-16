using envrep.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace envrep.DataAccess
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base("RecordContext")
        {
        }

        public DbSet<RecordPostViewModel> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
