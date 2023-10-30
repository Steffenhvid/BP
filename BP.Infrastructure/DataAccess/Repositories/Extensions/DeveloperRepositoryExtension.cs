using BP.Infrastructure.Entities;
using BP.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess.Repositories.Extensions
{
    public static class DeveloperRepositoryExtension
    {
        public static async Task<List<DeveloperEntity>> GetAllDevelopers(this IRepository<DeveloperEntity> repository)
        {
            return await repository
                .GetTable()
                .Include(x => x.Skills)
                .ToListAsync();
        }
    }
}