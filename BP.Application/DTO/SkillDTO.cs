using AutoMapper;
using BP.Application.Common.Interfaces;
using BP.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.DTO
{
    public class SkillDTO : IMapFrom<SkillEntity>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public void Mapping(Profile profile) => profile.CreateMap(typeof(SkillEntity), GetType()).ReverseMap();
    }
}