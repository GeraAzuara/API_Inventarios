using System.Security.Principal;
using System.Security.Claims;

namespace InventariosAPI.Data.Utils
{
    public class AuthHelper
    {
        public static string GetValue(IPrincipal User, string Property)
        {
            var r = ((ClaimsIdentity)User.Identity).FindFirst(Property);
            return r == null ? "" : r.Value;
        }

        public static string GetNameIdentifier(IPrincipal User)
        {
            var r = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier);
            return r == null ? "" : r.Value;
        }

        public static string GetName(IPrincipal User)
        {
            var r = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name);
            return r == null ? "" : r.Value;
        }

        //indica si el usuario tiene acceso a un recurso
        public static bool GetPrivilege(IPrincipal User, string Property)
        {
            var r = ((ClaimsIdentity)User.Identity).FindFirst(Property);
            //return r == null ? false : r.Value.Equals('S') ? true : false;

            return (r != null);
        }
    }
}
