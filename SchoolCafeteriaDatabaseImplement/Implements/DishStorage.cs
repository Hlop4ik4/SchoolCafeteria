using Microsoft.EntityFrameworkCore;
using SchoolCafeteriaContracts.ViewModels;
using SchoolCafeteriaDatabaseImplement.Models;
using SchoolCefeteriaContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Implements
{
    public class DishStorage
    {
        public List<DishViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.Dishes
                .Select(CreateModel)
                .ToList();
        }

        public List<DishViewModel> GetElementsByIds(string ids)
        {
            string[] idArrString = ids.Split(',');
            int[] idArrInt = new int[idArrString.Length];

            for(int i = 0; i < idArrString.Length; i++)
            {
                idArrInt[i] = Convert.ToInt32(idArrString[i]);
            }

            using var context = new SchoolCafeteriaDatabase();
            var dish = context.Dishes
                                .Where(u => idArrInt.Contains(u.Id))
                                .Select(CreateModel)
                                .ToList();
            return dish != null ? dish : null;
        }

        public List<DishViewModel> GetFilteredListByOrderId(int orderId)
        {
            using var context = new SchoolCafeteriaDatabase();

            var order = context.Orders
                .Include(rec => rec.DishOrders)
                .ThenInclude(rec => rec.Dish)
                .FirstOrDefault(rec => rec.Id == orderId);

            var orderViewModel = CreateOrderViewModel(order);

            var dishes = context.Dishes
                                .Where(g => orderViewModel.DishOrder.Contains(Convert.ToString(g.Id)))
                                .Select(CreateModel)
                                .ToList();
            return dishes != null ? dishes : null;
        }

        public void Insert(DishViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();

            context.Dishes.Add(CreateModel(model, new Dish()));
            context.SaveChanges();
        }

        public void Update(DishViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();
            var dishes = context.Dishes.FirstOrDefault(g => g.Id == Convert.ToInt32(model.Id));
            if (dishes == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, dishes);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var dishes = context.Dishes.FirstOrDefault(g => g.Id == Id);
            if (dishes == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.Dishes.Remove(dishes);
            context.SaveChanges();
        }

        private static DishViewModel CreateModel(Dish dish)
        {
            return new DishViewModel
            {
                Id = Convert.ToString(dish.Id),
                Name = dish.Name,
                Price = Convert.ToString(dish.Price)
            };
        }

        private static Dish CreateModel(DishViewModel model, Dish dish)
        {
            dish.Name = model.Name;
            dish.Price = Convert.ToDecimal(model.Price);
            return dish;
        }

        private static OrderViewModel CreateOrderViewModel(Order order)
        {
            var list = new List<string>();
            foreach (var dishOrder in order.DishOrders)
            {
                list.Add(Convert.ToString(dishOrder.DishId));
            }
            return new OrderViewModel
            {
                Id = Convert.ToString(order.Id),
                Price = Convert.ToString(order.Price),
                SumToPay = Convert.ToString(order.SumToPay),
                DishOrder = list
            };
        }
    }
}
