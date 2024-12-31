using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    public class Budget
    {
        [Key]
        public int IdB { get; set; }
        public float montantTotal { get; set; }
        public float seuil {  get; set; }
        public DateTime date_deb { get; set; }
        public DateTime date_fin { get; set; }
        [ForeignKey("Utilisateur")]
        public int IdU { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
