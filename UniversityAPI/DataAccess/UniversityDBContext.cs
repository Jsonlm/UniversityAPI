using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UniversityAPI.Models.DataModels;

namespace UniversityAPI.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }

        //TODO: Add DBSets (Tables of our Database)
        public DbSet<User>? Users { get; set; }
    }
}
