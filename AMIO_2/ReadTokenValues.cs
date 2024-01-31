using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AMIO_2
{
    public class ReadTokenValues
    {
        public string GetRoleFromToken(string jwtToken)
        {
            if (jwtToken != null)
            {
                // Instance d'un objet JwtSecurityTokenHandler pour pouvoir accéder à la propriété de lecture du jeton.
                JwtSecurityTokenHandler tokenReadAccess = new JwtSecurityTokenHandler();

                // Lecture du jeton JWT grâce à la propriété .ReadToken :
                JwtSecurityToken jwtSecurityToken = tokenReadAccess.ReadToken(jwtToken) as JwtSecurityToken;

                // Déclaration de la variable roleClaim en dehors du bloc if pour rendre sa portée plus large.
                Claim roleClaim = null;

                // Si le jeton contient des éléments
                if (jwtSecurityToken != null)
                {
                    // Extraction des revendications (informations) du jeton:
                    var claims = jwtSecurityToken.Claims;

                    // Recherche de la revendication (claim (information)) correspondante au rôle contenu dans le Token
                    roleClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
                    // Si le rôle est bien récupéré dans le Token, on retourne la valeur du rôle récupérée:
                }

                if (roleClaim != null)
                {
                    // Renvoyer la valeur du rôle si elle existe.
                    return roleClaim.Value;
                }
                else
                {
                    return null;
                }
            }
            // Retourner null si le Token est null:
            return null;
        }
    }
}
