using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.Entities;

public class DeveloperEntity : BaseEntity
{
    public string Name { get; set; }
    public AdressEntity Adress { get; set; }
    public List<SkillEntity> Skills { get; set; }
    public string UserName { get; set; }
}