using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Datalayer
{
    public class Datacontextidentity : IdentityDbContext
    {
        public Datacontextidentity(DbContextOptions options) : base(options)
        {
        }
    }
}
