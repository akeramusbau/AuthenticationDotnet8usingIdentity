using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuthenticationDotnet8usingIdentity.Models;

namespace AuthenticationDotnet8usingIdentity.Data
{
    public class AuthenticationDotnet8usingIdentityContext : DbContext
    {
        public AuthenticationDotnet8usingIdentityContext (DbContextOptions<AuthenticationDotnet8usingIdentityContext> options)
            : base(options)
        {
        }

        public DbSet<AuthenticationDotnet8usingIdentity.Models.Books> Books { get; set; } = default!;
    }
}
