using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users_manage_models
{
    public class Post
    {
        public int Id { get; set; }
        public string Contenu { get; set; }
        public DateTime Date { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
