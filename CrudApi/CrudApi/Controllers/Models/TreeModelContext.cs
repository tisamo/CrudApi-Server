using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApi.Controllers.Models
{
    public class TreeModelContext : DbContext
    {
        public TreeModelContext(DbContextOptions<TreeModelContext> options) : base(options)
        {
        }

        public DbSet<TreeModel> TreeModels { get; set; }
    }
}
