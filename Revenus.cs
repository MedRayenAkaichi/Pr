using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    public class Revenus
    {
        [Key]
        public int IdR { get; set; }
        public string source { get; set; }
        public float montant {  get; set; }
        public DateTime date_R { get; set; }
        [ForeignKey("Utilisateur")]
        public int IdU { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
