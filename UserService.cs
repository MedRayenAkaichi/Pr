using Projet.BLL.Contract;
using Projet.Entities;
using Projet.Services.Interfaces;

namespace Projet.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private IGenericBLL<Utilisateur> _UtilisateurBLL;
        public UtilisateurService(IGenericBLL<Utilisateur> UtilisateurBll)
        {
            _UtilisateurBLL= UtilisateurBll;
        }
        public IEnumerable<Utilisateur> GetUtilisateurs()
        {
            return _UtilisateurBLL.GetMany();

        }
        void IUtilisateurService.AddUtilisateur(Utilisateur Utilisateur)
        {
            _UtilisateurBLL.Add(Utilisateur);
        }
        public void UpdateUtilisateur(Utilisateur utilisateur)
        {
            _UtilisateurBLL.Update(utilisateur); 
        }

        public void DeleteUtilisateur(int id)
        {
            var utilisateur = _UtilisateurBLL.GetById(id);
            if (utilisateur != null)
            {
                _UtilisateurBLL.Delete(utilisateur);
            }
            else
            {
                throw new Exception("Utilisateur non trouvé."); 
            }
        }

    }
}