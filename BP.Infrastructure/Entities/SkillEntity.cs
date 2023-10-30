using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.Entities
{
    [Owned]
    public class SkillEntity : BaseEntity
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }
}