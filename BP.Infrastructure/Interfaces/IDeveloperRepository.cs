using BP.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.Interfaces
{
    public interface IDeveloperRepository : IRepository<DeveloperEntity>
    {
        Task UpdateAllDevelopers(string NewName);

        Task<DeveloperEntity> GetDevByName(string Name);

        Task Test();
    }
}