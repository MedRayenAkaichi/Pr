using System.ComponentModel.DataAnnotations;

namespace Projet.Entities
{
    public class Utilisateur
    {
        [Key]
        public int IdU { get; set; }

        [Required]
        public string nom { get; set; }

        [Required]
        public string prenom { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(6)]
        public string password { get; set; }
    }
}