using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Models.Forms
{
    //Form: on rentre des informations
    //Form permet de déclarer uniquement les elements de ta table avec lequel il peut avoir une interraction ou avoir connaissance,
    //par exemple on ne met pas l'id car ce n est pas à lui de le rentrer
    public class CreateJobForm
    {
        public string? Name { get; set; }
        public string? Sector { get; set; }
        public string? CP { get; set; }
        public int MinimalSalary { get; set; }
    }
}
