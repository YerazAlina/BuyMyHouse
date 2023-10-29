using BuyMyHouse.Models;
using Microsoft.EntityFrameworkCore;

namespace BuyMyHouse.DAL
{
    public class BuyMyHouseDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<House> Houses { get; set; }
        DbSet<Mortgage> Mortgages { get; set; }
        
        public BuyMyHouseDbContext(DbContextOptions<BuyMyHouseDbContext> options) : base(options) { }
    }
}
