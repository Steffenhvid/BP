using AutoMapper;
using BP.Application.Common.Interfaces;
using BP.Application.DTO;
using BP.Infrastructure.Entities;
using BP.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BP.Application.UseCases.Developers.UpsertDeveloper;

namespace BP.Application.UseCases.Developers
{
    public class UpsertDeveloper : IUseCase<UpsertDeveloperInput, DeveloperDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DeveloperEntity> _developerRepository;

        public UpsertDeveloper(IMapper mapper, IRepository<DeveloperEntity> developerRepository)
        {
            _mapper = mapper;
            _developerRepository = developerRepository;
        }

        public async Task<DeveloperDTO> ExecuteAsync(UpsertDeveloperInput input)
        {
            DeveloperEntity developerEntity = _mapper.Map<DeveloperEntity>(input);
            var updatedEntry = _developerRepository.Update(developerEntity);
            await _developerRepository.SaveAsync();

            return _mapper.Map<DeveloperDTO>(updatedEntry);
        }

        public record UpsertDeveloperInput(DeveloperDTO DeveloperDTO);
    }
}