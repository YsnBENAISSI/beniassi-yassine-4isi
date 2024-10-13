using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using users_manage_data;
using users_manage_models;

namespace users_manage_services
{
    internal class UtilisateurService : IUtilisateurService
    {
        private readonly AppDbContext _context;

        public UtilisateurService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Utilisateur> InscrireUtilisateur(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
            return utilisateur;
        }

        public async Task<Utilisateur> Authentifier(string login, string password)
        {
            return await _context.Utilisateurs.FirstOrDefaultAsync(u => u.Login == login && u.Password == password);
        }
    }
}
