using BP.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess.ModelExtensions
{
    public static class DeveloperConfiguration
    {
        public static ModelBuilder ConfigureDeveloperEntity<T>(this ModelBuilder builder) where T : DeveloperEntity
        {
            builder.Entity<T>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<T>().Property("AdressId").HasComment("Test");

            return builder;
        }
    }
}