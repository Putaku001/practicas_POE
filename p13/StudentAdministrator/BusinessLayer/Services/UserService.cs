using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
	public class UserService
	{
		private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User? GetRegisterdUser(string username, string password)
        {
            return _userRepository.GetRegisteredUser(username, password);
        }
    }
}
