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
    }
}
