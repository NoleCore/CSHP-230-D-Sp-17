﻿using System.Linq;

namespace Final.Repository
{
    public interface IUserRepository
    {
        UserModel LogIn(string email, string password);
        UserModel Register(string email, string password);
    }

    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserRepository : IUserRepository
    {
        public UserModel LogIn(string email, string password)
        {
            var user = DatabaseAccessor.Instance.Users
                .FirstOrDefault(t => t.UserEmail.ToLower() == email.ToLower()
                                      );

            if (user == null)
            {
                return null;
            }

            return new UserModel { Id = user.UserId, Name = user.UserEmail };
        }

        public UserModel Register(string email, string password)
        {
            var existingUser = DatabaseAccessor.Instance.Users.FirstOrDefault(t => t.UserEmail.ToLower() == email);

            if (existingUser != null)
            {
                return null;
            }

            var user = DatabaseAccessor.Instance.Users
                    .Add(new Final.ProductDatabase.User { UserEmail = email, UserPassword = password });

            DatabaseAccessor.Instance.SaveChanges();

            return new UserModel { Id = user.UserId, Name = user.UserEmail };
        }
    }
}
