using Projet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Services.Interfaces
{
    public interface IUtilisateurService
    {
        IEnumerable<Utilisateur> GetUtilisateurs();
        public void AddUtilisateur(Utilisateur Utilisateur);

        public void DeleteUtilisateur(int id);
        public void UpdateUtilisateur(Utilisateur Utilisateur);
    }
}
