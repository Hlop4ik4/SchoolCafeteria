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
    public class OrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.Orders
                .Include(t => t.DishOrders)
                .ThenInclude(t => t.Dish)
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public OrderViewModel GetElement(int id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var order = context.Orders
                .Include(rec => rec.DishOrders)
                .ThenInclude(rec => rec.Dish)
                .FirstOrDefault(rec => rec.Id == id);
            return order != null ? CreateModel(order) : null;
        }

        public void Insert(OrderViewModel model)
        {
            using var context = new SchoolCafeteriaDatabase();
            using var transaction = context.Database.BeginTransaction();

            try
            {
                var order = new Order
                {
                    Price = Convert.ToDecimal(model.Price),
                    SumToPay = Convert.ToDecimal(model.SumToPay)
                };
                context.Orders.Add(order);
                context.SaveChanges();

                CreateModel(model, order, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(OrderViewModel model)
        {
            using var context = new SchoolCafeteriaDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Orders.FirstOrDefault(rec => rec.Id == Convert.ToInt32(model.Id));
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                element.Price = Convert.ToDecimal(model.Price);
                element.SumToPay = Convert.ToDecimal(model.SumToPay);

                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Delete(int id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var element = context.Orders.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Orders.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public static Order CreateModel(OrderViewModel model, Order order, SchoolCafeteriaDatabase context)
        {
            order.Price = Convert.ToDecimal(model.Price);
            order.SumToPay = Convert.ToDecimal(model.SumToPay);

            if (string.IsNullOrEmpty(model.Id))
            {
                var dishOrders = context.DishOrders.Where(rec =>
                rec.OrderId == Convert.ToInt32(model.Id)).ToList();
                context.DishOrders.RemoveRange(dishOrders.Where(rec =>
                !model.DishOrder.Contains(Convert.ToString(rec.DishId))).ToList());
                context.SaveChanges();
                foreach (var dishOrder in dishOrders)
                {
                    model.DishOrder.Remove(Convert.ToString(dishOrder.DishId));
                }
                context.SaveChanges();
            }
            foreach (var dishOrder in model.DishOrder)
            {
                context.DishOrders.Add(new DishOrder
                {
                    OrderId = order.Id,
                    DishId = Convert.ToInt32(dishOrder)
                });
                context.SaveChanges();
            }
            return order;
        }

        private static OrderViewModel CreateModel(Order order)
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
