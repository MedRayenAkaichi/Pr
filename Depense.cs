using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    public class Depense
    {
        [Key]
        public int IdD {  get; set; }
        public string categorie { get; set; }
        public float montant { get; set; }

        public string description { get; set; }
        public DateTime date_D { get; set; }
        [ForeignKey ("Utilisateur")]
            public int IdU { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
