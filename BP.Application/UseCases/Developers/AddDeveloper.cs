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
using static BP.Application.UseCases.Developers.AddDeveloper;

namespace BP.Application.UseCases.Developers
{
    public class AddDeveloper : IUseCase<AddDeveloperInput>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DeveloperEntity> _devRepo;

        public record AddDeveloperInput(DeveloperDTO Developer);

        public AddDeveloper(IMapper mapper, IRepository<DeveloperEntity> devRepo)
        {
            _mapper = mapper;
            _devRepo = devRepo;
        }

        public async Task ExecuteAsync(AddDeveloperInput input)
        {
            DeveloperEntity developerEntity = _mapper.Map<DeveloperEntity>(input);
            _devRepo.Insert(developerEntity);
            await _devRepo.SaveAsync();
        }
    }
}