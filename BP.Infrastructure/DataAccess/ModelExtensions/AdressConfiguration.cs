using BP.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess.ModelExtensions
{
    public static class AdressConfiguration
    {
        public static ModelBuilder ConfigureAdressEntity<T>(this ModelBuilder builder) where T : AdressEntity
        {
            builder.Entity<T>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            return builder;
        }
    }
}