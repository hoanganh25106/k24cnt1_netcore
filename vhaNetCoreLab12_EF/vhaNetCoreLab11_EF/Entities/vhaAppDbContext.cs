using Microsoft.EntityFrameworkCore;
using vhaNetCoreLab11_EF.Models;
namespace vhaNetCoreLab11_EF.Entities
{
	public class vhaAppDbContext : DbContext
	{
		public vhaAppDbContext(DbContextOptions<vhaAppDbContext> options) : base(options) { }
		public DbSet<vhaCategory> categories { get; set; }
		public DbSet<vhaProducts> products { get; set; }
	}
}
