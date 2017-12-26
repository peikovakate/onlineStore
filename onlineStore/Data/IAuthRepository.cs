using onlineStore.Models;
using System.Threading.Tasks;

namespace onlineStore.Data
{
    public interface IAuthRepository
    {
        Task<Administrator> Register(Administrator admin, string password);
        Task<Administrator> Login(string username, string password);
        Task<bool> AdministratorExists(string username);

    }
}
