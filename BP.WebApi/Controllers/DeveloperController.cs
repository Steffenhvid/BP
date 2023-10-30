using BP.Application.Common.Interfaces;
using BP.Application.DTO;
using Microsoft.AspNetCore.Mvc;
using static BP.Application.UseCases.Developers.AddDeveloper;
using static BP.Application.UseCases.Developers.GetDevelopers;
using static BP.Application.UseCases.Developers.UpsertDeveloper;

namespace BP.WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DeveloperController : Controller
    {
        private readonly IUseCase<GetDevelopersInput, List<DeveloperDTO>> _getDevelopers;
        private readonly IUseCase<AddDeveloperInput> _addDeveloper;
        private readonly IUseCase<UpsertDeveloperInput, DeveloperDTO> _upsertDeveloper;

        public DeveloperController(
            IUseCase<GetDevelopersInput, List<DeveloperDTO>> getDevelopers,
            IUseCase<AddDeveloperInput> addDeveloper,
            IUseCase<UpsertDeveloperInput, DeveloperDTO> upsertDeveloper)
        {
            _getDevelopers = getDevelopers;
            _addDeveloper = addDeveloper;
            _upsertDeveloper = upsertDeveloper;
        }

        [HttpGet("GetDevelopers/")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _getDevelopers.ExecuteAsync(new GetDevelopersInput()));
        }

        [HttpPost("AddDeveloper/")]
        public async Task<IActionResult> Post([FromBody] DeveloperDTO developerDTO)
        {
            await _addDeveloper.ExecuteAsync(new AddDeveloperInput(developerDTO));
            return Ok();
        }

        [HttpPut("UpsertDeveloper/")]
        public async Task<IActionResult> Put([FromBody] DeveloperDTO developerDTO)
        {
            return Ok(await _upsertDeveloper.ExecuteAsync(new UpsertDeveloperInput(developerDTO)));
        }
    }
}