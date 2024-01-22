using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCafeteriaContracts.ViewModels;
using SchoolCafeteriaDatabaseImplement.Models;

namespace SchoolCafeteriaDatabaseImplement.Implements
{
    public class UserStorage
    {
        public List<UserViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.Users
                .Select(CreateModel)
                .ToList();
        }

        public UserViewModel GetElement(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var user = context.Users.FirstOrDefault(u => u.Id == Id);
            return user != null ? CreateModel(user) : null;
        }

        public void Insert(UserViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();

            context.Users.Add(CreateModel(model, new User()));
            context.SaveChanges();
        }

        public void Update(UserViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();
            var user = context.Users.FirstOrDefault(u => u.Id == model.Id);
            if (user == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, user);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var user = context.Users.FirstOrDefault(u => u.Id == Id);
            if (user == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.Users.Remove(user);
            context.SaveChanges();
        }

        private static UserViewModel CreateModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                FullName = user.FullName
            };
        }

        private static User CreateModel(UserViewModel model, User user)
        {
            user.Login = model.Login;
            user.Password = model.Password;
            user.FullName = model.FullName;
            return user;
        }
    }
}
