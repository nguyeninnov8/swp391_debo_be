﻿using swp391_debo_be.Models;
using swp391_debo_be.Repository.Implement;
using swp391_debo_be.Repository.Interface;

namespace swp391_debo_be.Cores
{
    public class CUser
    {
        protected static IUserRepository _userRepository = new UserRepository();

        public static User GetUserByPhoneNumber(string phoneNumber)
        {
            return _userRepository.GetUserByPhone(phoneNumber);
        }

        public static User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }
        public static string[] GetRoleName(User user)
        {
           return _userRepository.getRolesName(user);
        }
    }
}
