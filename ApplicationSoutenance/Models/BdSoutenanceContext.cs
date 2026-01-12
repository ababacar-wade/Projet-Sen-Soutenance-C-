using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{

    // Configure le contexte pour utiliser MySQL avec Entity Framework
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    // Classe de contexte qui hérite de DbContext pour gérer la base de données
    public class BdSoutenanceContext: DbContext
    {
        // Constructeur qui initialise le contexte avec la chaîne de connexion nommée "connBdSenSoutenance"
        public BdSoutenanceContext():base("connBdSoutenance") { }

        // DbSet représentant la table des années académiques dans la base de données
        public DbSet<AnneeAcademique> anneeAcademiques { get; set; }

        // DbSet représentant la table des sessions
        public DbSet<Session> sessions { get; set; }

        // DbSet représentant la table des mémoires
        public DbSet<Memoire> memoires { get; set; }

        // DbSet représentant la table des soutenances
        public DbSet<Soutenance> soutenances { get; set; }

        // DbSet représentant la table des utilisateurs
        public DbSet<Utilisateur> utilisateurs { get; set; }

        // DbSet représentant la table des administrateurs 
        public DbSet<Admin> admins { get; set; }

        // DbSet représentant la table des chefs de departement
        public DbSet<ChefDepartement> chefDepartements { get; set; }

        // DbSet représentant la table des professeurs
        public DbSet<Professeur> professeurs { get; set; }

        // DbSet représentant la table des candidats
        public DbSet<Candidat> candidats { get; set; }
        // DbSet représentant la table des departements
        public DbSet<Departement> departements { get; set; }
    }
}
