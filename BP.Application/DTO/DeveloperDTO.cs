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
    public class DeveloperDTO : IMapFrom<DeveloperEntity>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SkillDTO> Skills { get; set; }
        public AdressDTO Adress { get; set; }

        public string UserName { get; set; }

        public void Mapping(Profile profile) => profile.CreateMap(typeof(DeveloperEntity), GetType()).ReverseMap();
    }
}