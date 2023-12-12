using API.Models.DTO;
using LayersArchiDemo_DAL.Entities;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class JobMapper
    {
        public static JobDTO ToDTO(this Job job)
        {
            return new JobDTO
            {
                Id = job.Id,
                Name = job.Name,
                Sector = job.Sector,
                CP = job.CP,
                MinimalSalary = job.MinimalSalary,
            };
        }
    }
}
