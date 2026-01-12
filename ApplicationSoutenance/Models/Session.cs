using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    public class Session
    {
        // [Key] indique que cette propriété est la clé primaire de la table Session
        [Key]
        public int IdSession { get; set; }

        // [Required] : champ obligatoire 
        // [MaxLength(50)] : longueur maximale de 50 caractères
        public string LibelleSession { get; set; }

        // Clé étrangère vers la table AnneeAcademique
        // Le ? signifie que la valeur peut être NULL
        public int? IdAnneeAcademique { get; set; }

        // [ForeignKey] précise que cette propriété de navigation
        // est liée à la clé étrangère IdAnneeAcademique
        [ForeignKey("IdAnneeAcademique")]
        public virtual AnneeAcademique AnneeAcademique { get; set; }
        // "virtual" permet le chargement paresseux (Lazy Loading) avec Entity Framework
    }
}
