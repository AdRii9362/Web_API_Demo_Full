using API.Mappers;
using API.Models.DTO;
using LayersArchiDemo_BLL.Interfaces;
using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_BLL.Services;
using LayersArchiDemo_DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobController(IJobService jobService)
        {
            _jobService = jobService;

        }
        [HttpGet]
        public ActionResult<IEnumerable<JobDTO>> GetAll()
        {
            return Ok(_jobService.GetAll().Select(x => x.ToDTO()));
        }

        [HttpPost]
        public ActionResult<JobDTO> Create(CreateJobForm form)
        {
            Job? job = _jobService.Create(form);

            if (job is null)
            {
                return BadRequest();
            }

            return Ok(job);
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<JobDTO> GetById(int id)
        {
            Job? job = _jobService.GetById(id);

            return job is null ? NotFound() : Ok(job.ToDTO());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            return _jobService.Delete(id) ? NoContent() : BadRequest();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update(int id, UpdateJobForm form)
        {
            return _jobService.Update(id, form) ? NoContent() : BadRequest();
        }
    }
}
