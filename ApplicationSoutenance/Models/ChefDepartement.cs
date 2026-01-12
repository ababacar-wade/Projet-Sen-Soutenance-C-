using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSoutenance.Models
{
    public class ChefDepartement:Utilisateur
    {
        // FK vers Departement. Nullable si un chef peut ne pas être assigné.
        public int? DepartementId { get; set; }
        [ForeignKey("DepartementId")]

        public virtual Departement Departement { get; set; }
    }
}
