using System;
using System.ComponentModel.DataAnnotations;

namespace EvalFinale_Natacha.Modeles
{
    public class CommandesFaitesPar
    {
        [Key]
        public int CommandeID { get; set; }
        public string? ClientID { get; set; }
        public int? EmployeID { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DateCommande { get; set; }
        public DateTime? DateRequise { get; set; }
        public DateTime? DateEnvoi { get; set; }
        public string? AdresseEnvoi { get; set; }
        public string? VilleEnvoi { get; set; }
        public string? CodePostalEnvoi { get; set; }
        public string? PaysEnvoi { get; set; }

    }
}
