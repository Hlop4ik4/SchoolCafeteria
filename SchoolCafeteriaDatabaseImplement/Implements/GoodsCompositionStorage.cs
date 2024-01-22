using SchoolCafeteriaContracts.ViewModels;
using SchoolCafeteriaDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Implements
{
    public class GoodsCompositionStorage
    {
        public List<GoodsCompositionViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.GoodsCompositions
                .Select(CreateModel)
                .ToList();
        }

        public GoodsCompositionViewModel GetElement(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var goodsComposition = context.GoodsCompositions.FirstOrDefault(gc => gc.Id == Id);
            return goodsComposition != null ? CreateModel(goodsComposition) : null;
        }

        public void Insert(GoodsCompositionViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();

            context.GoodsCompositions.Add(CreateModel(model, new GoodsComposition()));
            context.SaveChanges();
        }

        public void Update(GoodsCompositionViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();
            var goodsComposition = context.GoodsCompositions.FirstOrDefault(gc => gc.Id == model.Id);
            if (goodsComposition == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, goodsComposition);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var goodsComposition = context.GoodsCompositions.FirstOrDefault(gc => gc.Id == Id);
            if (goodsComposition == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.GoodsCompositions.Remove(goodsComposition);
            context.SaveChanges();
        }

        private static GoodsCompositionViewModel CreateModel(GoodsComposition goodsComposition)
        {
            return new GoodsCompositionViewModel
            {
                Id = goodsComposition.Id,
                GoodsId = goodsComposition.GoodsId,
                TechMapId = goodsComposition.TechMapId,
                Protein = goodsComposition.Protein,
                Fat = goodsComposition.Fat,
                Carb = goodsComposition.Carb,
                B1 = goodsComposition.B1,
                C = goodsComposition.C,
                A = goodsComposition.A,
                E = goodsComposition.E,
                Ca = goodsComposition.Ca,
                P = goodsComposition.P,
                Mg = goodsComposition.Mg,
                Fe = goodsComposition.Fe
            };
        }

        private static GoodsComposition CreateModel(GoodsCompositionViewModel model, GoodsComposition goodsComposition)
        {
            goodsComposition.GoodsId = model.GoodsId;
            goodsComposition.TechMapId = model.TechMapId;
            goodsComposition.Protein = model.Protein;
            goodsComposition.Fat = model.Fat;
            goodsComposition.Carb = model.Carb;
            goodsComposition.B1 = model.B1;
            goodsComposition.C = model.C;
            goodsComposition.A = model.A;
            goodsComposition.E = model.E;
            goodsComposition.Ca = model.Ca;
            goodsComposition.P = model.P;
            goodsComposition.Mg = model.Mg;
            goodsComposition.Fe = model.Fe;
            return goodsComposition;
        }
    }
}
