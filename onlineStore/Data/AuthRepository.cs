using System.Threading.Tasks;
using onlineStore.Models;

namespace onlineStore.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<bool> AdministratorExists(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<Administrator> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Administrator> Register(Administrator admin, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
