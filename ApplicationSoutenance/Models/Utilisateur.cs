using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    // Classe de base représentant un utilisateur dans le système
    // Cette classe sera héritée par Admin, ChefDepartement, Professeur, Candidat
    public class Utilisateur
    {
        // Attribut [Key] définit cette propriété comme clé primaire de la table
        [Key]
        // Propriété contenant l'identifiant unique de l'utilisateur
        public int Idutilisateur { get; set; }

        // [Required] rend le champ obligatoire, [MaxLength(80)] limite à 80 caractères
        [Required, MaxLength(80)]
        // Propriété contenant le nom de famille de l'utilisateur
        public string Nomutilisateur { get; set; }

        // [Required] champ obligatoire, [MaxLength(80)] limite à 80 caractères
        [Required, MaxLength(80)]
        // Propriété contenant le prénom de l'utilisateur
        public string PrenomUtilisateur { get; set; }


        // [RegularExpression] valide le format du numéro de téléphone sénégalais
        // Format attendu: +221 suivi de 77/78/76/70/33 puis 7 chiffres
        // [Required] champ obligatoire, [MaxLength(15)] limite à 15 caractères
        [Required, MaxLength(15), RegularExpression(@"^\+221(77|78|76|70|33)[0-9]{7}$")]
        // Propriété contenant le numéro de téléphone de l'utilisateur
        public string TelUtilisateur { get; set; }

        // [Required] champ obligatoire, [MaxLength(80)] limite à 80 caractères
        // [DataType(DataType.EmailAddress)] spécifie que c'est un format email
        [Required, MaxLength(80), DataType(DataType.EmailAddress)]
        // Propriété contenant l'adresse email de l'utilisateur
        public string Email { get; set; }

        // [Required] champ obligatoire, [MaxLength(300)] limite à 300 caractères
        [Required, MaxLength(300)]
        // Propriété contenant le mot de passe hashé de l'utilisateur
        public string MotDePasse { get; set; }
    }
}
