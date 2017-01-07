using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Demo.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
    }
}
