using Microsoft.EntityFrameworkCore;

namespace Forum.Server.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions opions) : base(opions) 
        { 
            
        }
    }
}
