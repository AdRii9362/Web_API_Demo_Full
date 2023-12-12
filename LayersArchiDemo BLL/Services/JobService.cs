using LayersArchiDemo_BLL.Interfaces;
using LayersArchiDemo_BLL.Mappers;
using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;
using LayersArchiDemo_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public Job? Create(CreateJobForm form)
        {
            Job? job = _jobRepository.GetByCP(form.Name);

            if(job is null)
            {
                return _jobRepository.Create(form.ToJob());
            }
            return null;
        }

        public bool Delete(int id)
        {
            Job? job = _jobRepository.GetById(id);
            if(job is not null)
            {
                return _jobRepository.Delete(job);
            }
            return false;
        }

        public IEnumerable<Job> GetAll()
        {
            return _jobRepository.GetAll();
        }

        public Job? GetById(int id)
        {
            return _jobRepository.GetById(id);
        }

        public bool Update(int id, UpdateJobForm form)
        {
            Job? job = _jobRepository.GetById(id);
            if(job is not null)
            {
                job.Name = form.Name;
                job.Sector = form.Sector;
                job.CP = form.CP;
                job.MinimalSalary = form.MinimalSalary;

                return _jobRepository.Update(job);
            }
            return false;
        }
    }
}
