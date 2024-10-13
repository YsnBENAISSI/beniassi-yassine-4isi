using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using users_manage_models;

namespace users_manage_services
{
    public interface IUtilisateurService
    {
        Task<Utilisateur> InscrireUtilisateur(Utilisateur utilisateur);
        Task<Utilisateur> Authentifier(string login, string password);
    }
}
