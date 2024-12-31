using Microsoft.AspNetCore.Mvc;
using Projet.Entities;
using Projet.Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class UtilisateurController : Controller
    {
        IUtilisateurService _service;
        public UtilisateurController(IUtilisateurService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("AddUtilisateurs")]
        public IActionResult AddUtilisateurs([FromBody] Utilisateur user)
        {
            _service.AddUtilisateur(user);
            return NotFound();
        }

        [HttpGet]
        [Route("GetUtilisateurs")]
        public IActionResult GetUtilisateurs()
        {
            var listUtilisateurs = _service.GetUtilisateurs();
            if (listUtilisateurs != null)
            {
                return new OkObjectResult(listUtilisateurs);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUtilisateur(int id, [FromBody] Utilisateur user)
        {
            if (id != user.IdU)
            {
                return BadRequest("L'ID de l'utilisateur ne correspond pas.");
            }

            try
            {
                _service.UpdateUtilisateur(user);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message); // Gérer les exceptions
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUtilisateur(int id)
        {
            try
            {
                _service.DeleteUtilisateur(id);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message); // Gérer les exceptions
            }
        }

    }
}
