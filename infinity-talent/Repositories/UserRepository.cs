using infinity_talent.Data;
using infinity_talent.Data.Models;
using infinity_talent.Data.Services;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace infinity_talent.Repositories
{
    public class UserRepository
    {
        private AppDbContext _context;
        public UsersService _userService;
        string passHash = "";

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        

        public User Get(string username, string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                passHash = Util.Helpers.GetMd5Hash(md5Hash, password);
            }

            return _context.Users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == passHash).FirstOrDefault();   
        }
    }
}
