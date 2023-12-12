using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Mappers
{
    public static class JobMapper
    {
        public static Job ToJob(this CreateJobForm form)
        {
            return new Job()
            {
                Id = 0,
                Name = form.Name,
                Sector = form.Sector,
                CP = form.CP,
                MinimalSalary = form.MinimalSalary,
            };
        }
    }
}
