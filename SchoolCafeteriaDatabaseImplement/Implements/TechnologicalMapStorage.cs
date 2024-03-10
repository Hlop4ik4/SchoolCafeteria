using Microsoft.EntityFrameworkCore;
using SchoolCafeteriaContracts.ViewModels;
using SchoolCafeteriaDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Implements
{
    public class TechnologicalMapStorage
    {
        public List<TechnologicalMapViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.TechnologicalMaps
                .Include(t => t.TechMapGoods)
                .ThenInclude(t => t.Goods)
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public TechnologicalMapViewModel GetElement(int id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var techMap = context.TechnologicalMaps
            .Include(rec => rec.TechMapGoods)
            .ThenInclude(rec => rec.Goods)
            .FirstOrDefault(rec => rec.Id == id);
            return techMap != null ? CreateModel(techMap) : null;
        }

        public void Insert(TechnologicalMapViewModel model)
        {
            using var context = new SchoolCafeteriaDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var techMap = new TechnologicalMap
                {
                    DishName = model.DishName,
                    RecipeNumber = model.RecipeNumber,
                    CookingTechnology = model.CookingTechnology,
                    Description = model.Description
                };
                context.TechnologicalMaps.Add(techMap);
                context.SaveChanges();

                CreateModel(model, techMap, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(TechnologicalMapViewModel model)
        {
            using var context = new SchoolCafeteriaDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.TechnologicalMaps.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                element.DishName = model.DishName;
                element.RecipeNumber = model.RecipeNumber;
                element.CookingTechnology = model.CookingTechnology;
                element.Description = model.Description;

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
            var element = context.TechnologicalMaps.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.TechnologicalMaps.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public static TechnologicalMap CreateModel(TechnologicalMapViewModel model, TechnologicalMap techMap, SchoolCafeteriaDatabase context)
        {
            techMap.DishName = model.DishName;
            techMap.RecipeNumber = model.RecipeNumber;
            techMap.CookingTechnology = model.CookingTechnology;
            techMap.Description = model.Description;

            if (model.Id.HasValue)
            {
                var techMapGoods = context.TechMapGoods.Where(rec =>
                rec.TechMapId == model.Id.Value).ToList();
                context.TechMapGoods.RemoveRange(techMapGoods.Where(rec =>
                !model.TechMapGoods.Contains(rec.GoodsId)).ToList());
                context.SaveChanges();
                foreach (var techMapGood in techMapGoods)
                {
                    model.TechMapGoods.Remove(techMapGood.GoodsId);
                }
                context.SaveChanges();
            }
            foreach (var tg in model.TechMapGoods)
            {
                context.TechMapGoods.Add(new TechMapGoods
                {
                    TechMapId = techMap.Id,
                    GoodsId = tg
                });
                context.SaveChanges();
            }
            return techMap;
        }

        private static TechnologicalMapViewModel CreateModel(TechnologicalMap techMap)
        {
            var list = new List<int>();
            foreach(var techMapGoods in techMap.TechMapGoods)
            {
                list.Add(techMapGoods.GoodsId);
            }
            return new TechnologicalMapViewModel
            {
                Id = techMap.Id,
                DishName = techMap.DishName,
                RecipeNumber = techMap.RecipeNumber,
                CookingTechnology = techMap.CookingTechnology,
                Description = techMap.Description,
                TechMapGoods = list
            };
        }
    }
}
