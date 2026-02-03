using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    // Classe représentant une erreur dans l'application
    public class Td_Erreur
    {
        // Clé primaire de la table Td_Erreur
        [Key]
        public int Id_Erreur { get; set; }

        // Titre de l'erreur (limité à 200 caractères)
        [MaxLength(200)]
        public string TitreErreur { get; set; }

        // Description détaillée de l'erreur (limité à 2000 caractères)
        [MaxLength(2000)]
        public string DescriptionErreur { get; set; }

        // Date à laquelle l'erreur s'est produite
        public DateTime DateErreur { get; set; }
    }
}
