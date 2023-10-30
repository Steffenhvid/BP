using BP.Infrastructure.Entities;
using BP.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess.Repositories
{
    public class DeveloperRepository : GenericRepository<DeveloperEntity>, IDeveloperRepository
    {
        private readonly BPContext _bPContext;

        public DeveloperRepository(BPContext bPContext) : base(bPContext)
        {
            _bPContext = bPContext;
        }

        public async Task UpdateAllDevelopers(string NewName)
        {
            await _bPContext.Developers
                .ForEachAsync(x => x.Name = NewName);
            await _bPContext.SaveChangesAsync();
        }

        public async Task<DeveloperEntity?> GetDevByName(string Name)
        {
            var devToLookUp = await _bPContext.Developers.Where(x => x.Name == Name).FirstOrDefaultAsync();
            return await _bPContext.Developers.FirstOrDefaultAsync(x => x.Name == devToLookUp.Name);
        }

        public async Task Test()
        {
            var devToChange = await _bPContext.Developers.FirstOrDefaultAsync();
            devToChange!.Name = "Test";
            await _bPContext.SaveChangesAsync();
        }
    }
}