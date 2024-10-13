using Microsoft.AspNetCore.Mvc;
using users_manage_services;

namespace users_manage_api.Controllers
{
    public class UtilistauerController : ControllerBase
    {
        [ApiController]
        [Route("api/[controller]")]
        public class UtilisateurController : ControllerBase
        {
            private readonly IUtilisateurService _utilisateurService;

            public UtilisateurController(IUtilisateurService utilisateurService)
            {
                _utilisateurService = utilisateurService;
            }

            [HttpPost("inscrire")]
            public async Task<IActionResult> Inscrire([FromBody] users_manage_models.Utilisateur utilisateur)
            {
                var nouvelUtilisateur = await _utilisateurService.InscrireUtilisateur(utilisateur);
                return CreatedAtAction(nameof(Inscrire), new { id = nouvelUtilisateur.Id }, nouvelUtilisateur);
            }

            [HttpPost("authentifier")]
            public async Task<IActionResult> Authentifier([FromBody] LoginModel model)
            {
                var utilisateur = await _utilisateurService.Authentifier(model.Login, model.Password);
                if (utilisateur == null)
                    return Unauthorized();

                // Ici, vous devriez générer un token JWT pour l'authentification
                return Ok(new { message = "Authentification réussie" });
            }
        }

        // Controllers/PostController.cs
        [ApiController]
        [Route("api/[controller]")]
        public class PostController : ControllerBase
        {
            private readonly IPostService _postService;

            public PostController(IPostService postService)
            {
                _postService = postService;
            }

            [HttpPost]
            public async Task<IActionResult> AjouterPost([FromBody] Post post)
            {
                var nouveauPost = await _postService.AjouterPost(post);
                return CreatedAtAction(nameof(AjouterPost), new { id = nouveauPost.Id }, nouveauPost);
            }

            [HttpGet]
            public async Task<IActionResult> ListerPosts()
            {
                var posts = await _postService.ListerPosts();
                return Ok(posts);
            }
        }
}
