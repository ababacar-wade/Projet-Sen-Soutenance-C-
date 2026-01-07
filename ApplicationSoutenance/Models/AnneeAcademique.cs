using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    // Classe représentant une année académique dans le système
    public class AnneeAcademique
    {
        // Attribut [Key] indique que cette propriété est la clé primaire de la table
        [Key]
        // Propriété identifiant unique de l'année académique
        public int IdAnneeAcademique { get; set; }

        // [Required] rend ce champ obligatoire, [MaxLength(10)] limite à 10 caractères
        [Required, MaxLength(10)]
        // Propriété contenant le libellé/nom de l'année académique (ex: "2023-2024")
        public String LibelleAnneeAcademique { get; set; }

        // Attribut [Required] rend ce champ obligatoire en base de données
        [Required]
        // Propriété contenant la valeur numérique de l'année académique (ex: 2023)
        public int AnneeAcademiqueVal { get; set; }
    }
}
