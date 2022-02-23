using InventariosAPI.Data.Utils;
using System.Threading.Tasks;

namespace InventariosAPI.Data.Interfaces
{
    public interface IAuthService
    {
        /// <summary>
        /// Delega la autenticación y la autorización al Cliente consumidor
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        AuthResponse AuthorizeDefault(InfoConsumidor model);
    }
}
