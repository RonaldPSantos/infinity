using infinity_talent.Data.Services;
using infinity_talent.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace infinity_talent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        public CandidatesService _candidateService;
        public CandidatesController(CandidatesService canndidateService)
        {
            _candidateService = canndidateService;
        }

        [Authorize]
        [HttpPost("add-candidate")]
        public IActionResult AddCandidate([FromBody] CandidateVM candidate)
        {
            _candidateService.AddCandidate(candidate);
            return Ok();
        }

        [Authorize]
        [HttpGet("get-all-candidates")]
        public IActionResult GetAllCandidates()
        {
            var allCandidates = _candidateService.GetAllCandidates();
            return Ok(allCandidates);
        }

        [HttpGet("get-candidate-by-id/{id}")]
        public IActionResult GetCandidateById(int id)
        {
            var candidate = _candidateService.GetCandidateById(id);
            return Ok(candidate);
        }

        [Authorize]
        [HttpPut("update-candidate-by-id/{id}")]
        public IActionResult UpdateCandidate(int id, [FromBody] CandidateVM candidate)
        {
            var updateCandidate = _candidateService.UpdateCandidate(id, candidate);
            return Ok(updateCandidate);
        }

        [HttpDelete("delete-candidate-by-id/{id}")]
        public IActionResult DeleteCandidateById(int id)
        {
            _candidateService.DeleteBookById(id);
            return Ok();
        }
    }
}
