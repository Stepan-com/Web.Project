using Mondy.Domain.Entities;
using System.Data.Entity;

namespace Mondy.BusinessLogic.Database
{
	public class UserContext : DbContext
	{
		public UserContext()
			: base("name=Mondy") { }

		public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}