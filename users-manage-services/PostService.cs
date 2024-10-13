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
    public class PostService : IPostService
    {
        private readonly AppDbContext _context;

        public PostService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Post> AjouterPost(Post post)
        {
            post.Date = DateTime.Now;
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<IEnumerable<Post>> ListerPosts()
        {
            return await _context.Posts.Include(p => p.Utilisateur).ToListAsync();
        }
    }
}
