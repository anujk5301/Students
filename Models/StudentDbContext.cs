using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gitproduct.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext( DbContextOptions options) : base(options)
        {
        }
    }
}
