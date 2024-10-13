using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user-manager-models
{
    class Post
    {
        private int Id { get; set; }
        private string Contenu { get; set; }
        private DateTime Date { get; set; }
        private int UtilisateurId { get; set; }
        private Utilisateur Utilisateur { get; set; }
    }
}
