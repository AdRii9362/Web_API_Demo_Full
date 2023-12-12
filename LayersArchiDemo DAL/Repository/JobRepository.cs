using LayersArchiDemo_DAL.Context;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Repository
{
    public class JobRepository : IJobRepository
    {
        public Job? Create(Job job)
        {
            job.Id = FakeDB.Jobs.Max(x => x.Id)+1;

            FakeDB.Jobs.Add(job);

            return job;
        }

        public bool Delete(Job job)
        {
            FakeDB.Jobs.Remove(job);
            return true;
        }

        public IEnumerable<Job> GetAll()
        {
            return FakeDB.Jobs;
        }

        public Job? GetByCP(string cp)
        {
            return FakeDB.Jobs.SingleOrDefault(x => x.CP == cp);
        }

        public Job? GetById(int id)
        {
            return FakeDB.Jobs.SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Job job)
        {
            int index = FakeDB.Jobs.FindIndex(x => x.Id == job.Id);

            FakeDB.Jobs[index] = job;

            return true;
        }
    }
}
