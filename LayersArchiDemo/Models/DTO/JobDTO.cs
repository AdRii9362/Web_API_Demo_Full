namespace API.Models.DTO
{
    //DTO : on sort des informations
    //DTO permet de déclarer uniquement les elements de ta table avec lequel il peut avoir connaissance,
    //l utilisateur peut lire toutes les donnees faisant partie de la DTO
    public class JobDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Sector { get; set; }

        public string? CP { get; set; }

        public int MinimalSalary { get; set; }
    }
}
