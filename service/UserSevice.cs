using Core.Reposetories;
using Core.Services;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserSevice : IUserService
    {
        private readonly IUserReposetory _userRepo;
        public UserSevice(IUserReposetory userRepo) {
            _userRepo = userRepo;
        }
        public User AddUser(User user)
        {
            return _userRepo.AddUser(user);
        }

        public User GetUserBy(string email, string password)
        {
            return _userRepo.GetUserBy(email, password);
        }
    }
}
