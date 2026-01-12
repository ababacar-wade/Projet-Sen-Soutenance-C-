using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    public class Soutenance
    {
        // [Key] indique que cette propriété est la clé primaire de la table Utilisateur
        [Key]
        public int IdUtilisateur { get; set; }

        // Nom de l'utilisateur
        // [Required] : champ obligatoire
        // [MaxLength(80)] : maximum 80 caractères
        public string NomUtilisateur { get; set; }

        // Prénom de l'utilisateur
        // [Required] : champ obligatoire
        // [MaxLength(80)] : maximum 80 caractères
        public string PrenomUtilisateur { get; set; }

        // Numéro de téléphone de l'utilisateur
        // [Required] : champ obligatoire
        // [MaxLength(15)] : limite la taille du numéro
        public string TelUtilisateur { get; set; }

        // Adresse email de l'utilisateur
        // [Required] : champ obligatoire
        // [MaxLength(80)] : maximum 80 caractères
        // [DataType(DataType.EmailAddress)] : indique qu'il s'agit d'un email
        // (utile surtout pour la validation et l'interface)
        [Required, MaxLength(80), DataType(DataType.EmailAddress)]
        public string EmailUtilisateur { get; set; }

        // Mot de passe de l'utilisateur
        public string MotDePasse { get; set; }
    }
}

