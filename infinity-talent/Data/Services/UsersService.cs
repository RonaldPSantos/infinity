using infinity_talent.Data.Models;
using infinity_talent.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace infinity_talent.Data.Services
{
    public class UsersService
    {
        private AppDbContext _context;
        public UsersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(UserVM user)
        {
            var _user = new User()
            {
                Username = user.Username,
                Password = user.Password,
                Role = user.Role
            };

            using (MD5 md5Hash = MD5.Create())
            {
                _user.Password = Util.Helpers.GetMd5Hash(md5Hash, _user.Password);
            }
            _context.Users.Add(_user);
            _context.SaveChanges();


        }

        public List<User> GetAllUsers() => _context.Users.ToList();
        public User GetUserByID(int userId) { return _context.Users.FirstOrDefault(x => x.Id == userId); }
        public User GetUserLogin(string userName, string pass) { return _context.Users.FirstOrDefault(n => n.Username == userName && n.Password == pass); }
        public User UpdateUser(int userId, UserVM user)
        {
            var _user = _context.Users.FirstOrDefault(n => n.Id == userId);
            if (_user != null)
            {
                _user.Username = user.Username;
                using (MD5 md5Hash = MD5.Create())
                {
                    _user.Password = Util.Helpers.GetMd5Hash(md5Hash, _user.Password);
                }
                _user.Role = user.Role;

                _context.SaveChanges();
            }
            return _user;
        }
    }
}
