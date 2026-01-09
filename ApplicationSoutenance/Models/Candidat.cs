using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    public class Candidat:Utilisateur
    {
        //ce champ est obligatoire et la taille maximum est de 20  caracteres
        [Required, MaxLength(20)]
        // propriete contenant le matricule du candidat
        public string MatriculeCandidat { get; set; }
    }
}
