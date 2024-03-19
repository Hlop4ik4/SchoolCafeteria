using SchoolCafeteriaContracts.ViewModels;
using SchoolCafeteriaDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Implements
{
    public class GoodsStorage
    {
        public List<GoodsViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.Goods
                .Select(CreateModel)
                .ToList();
        }

        public GoodsViewModel GetElement(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var goods = context.Goods.FirstOrDefault(g => g.Id == Id);
            return goods != null ? CreateModel(goods) : null;
        }

        public void Insert(GoodsViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();

            context.Goods.Add(CreateModel(model, new Goods()));
            context.SaveChanges();
        }

        public void Update(GoodsViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();
            var goods = context.Goods.FirstOrDefault(g => g.Id == Convert.ToInt32(model.Id));
            if (goods == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, goods);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var goods = context.Goods.FirstOrDefault(g => g.Id == Id);
            if (goods == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.Goods.Remove(goods);
            context.SaveChanges();
        }

        private static GoodsViewModel CreateModel(Goods goods)
        {
            return new GoodsViewModel
            {
                Id = Convert.ToString(goods.Id),
                Name = goods.Name,
                BruttoMass = Convert.ToString(goods.BruttoMass),
                NettoMass = Convert.ToString(goods.NettoMass),
                MarkToDelete = Convert.ToString(goods.MarkToDelete)
            };
        }

        private static Goods CreateModel(GoodsViewModel model, Goods goods)
        {
            goods.Name = model.Name;
            goods.BruttoMass = Convert.ToInt32(model.BruttoMass);
            goods.NettoMass = Convert.ToInt32(model.NettoMass);
            goods.MarkToDelete = Convert.ToBoolean(model.MarkToDelete);
            return goods;
        }
    }
}
