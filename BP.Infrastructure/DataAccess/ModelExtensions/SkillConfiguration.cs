using BP.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess.ModelExtensions
{
    public static class SkillConfiguration
    {
        public static ModelBuilder ConfigureSkillEntity<T>(this ModelBuilder builder) where T : SkillEntity
        {
            builder.Entity<T>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<T>().HasMany<DeveloperEntity>();

            builder.Entity<T>().Property("DeveloperEntityId").HasComment("Test");

            return builder;
        }
    }
}