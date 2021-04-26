using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_927.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_927.DataAccess
{
    public class EFContext : IdentityDbContext<User>
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) {  }
    }
}
