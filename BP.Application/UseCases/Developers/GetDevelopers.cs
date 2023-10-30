using AutoMapper;
using BP.Application.Common.Interfaces;
using BP.Application.DTO;
using BP.Infrastructure.DataAccess.Repositories.Extensions;
using BP.Infrastructure.Entities;
using BP.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BP.Application.UseCases.Developers.GetDevelopers;

namespace BP.Application.UseCases.Developers
{
    public class GetDevelopers : IUseCase<GetDevelopersInput, List<DeveloperDTO>>
    {
        public record GetDevelopersInput();
        private readonly IMapper _mapper;
        private readonly IRepository<DeveloperEntity> _developerRepository;

        public GetDevelopers(IMapper mapper, IRepository<DeveloperEntity> developerRepository)
        {
            _mapper = mapper;
            _developerRepository = developerRepository;
        }

        public async Task<List<DeveloperDTO>> ExecuteAsync(GetDevelopersInput input)
        {
            var developers = await _developerRepository.GetAllAsync();
            return _mapper.Map<List<DeveloperDTO>>(developers);
        }
    }
}