using Microsoft.EntityFrameworkCore;

namespace AdminPanelCRUD.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options){}

        public DbSet<Slider> Sliders { get; set; }

    }
}
