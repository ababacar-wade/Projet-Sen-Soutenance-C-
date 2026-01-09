using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    public class Departement
    {


        [Key]
        // propriete identifiant unique de departement
        public int IdDepartement { get; set; }

        // c'est obligatoire et la limite est de 80 caracteres
        [Required, MaxLength(80)]
        // propriete contenant libelle du departement
        public string Libelle { get; set; }
    }
}
