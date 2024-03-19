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
            var goodsComposition = context.GoodsCompositions.FirstOrDefault(gc => gc.Id == Convert.ToInt32(model.Id));
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
                Id = Convert.ToString(goodsComposition.Id),
                GoodsId = Convert.ToString(goodsComposition.GoodsId),
                Protein = Convert.ToString(goodsComposition.Protein),
                Fat = Convert.ToString(goodsComposition.Fat),
                Carb = Convert.ToString(goodsComposition.Carb),
                B1 = Convert.ToString(goodsComposition.B1),
                C = Convert.ToString(goodsComposition.C),
                A = Convert.ToString(goodsComposition.A),
                E = Convert.ToString(goodsComposition.E),
                Ca = Convert.ToString(goodsComposition.Ca),
                P = Convert.ToString(goodsComposition.P),
                Mg = Convert.ToString(goodsComposition.Mg),
                Fe = Convert.ToString(goodsComposition.Fe)
            };
        }

        private static GoodsComposition CreateModel(GoodsCompositionViewModel model, GoodsComposition goodsComposition)
        {
            goodsComposition.GoodsId = Convert.ToInt32(model.GoodsId);
            goodsComposition.Protein = Convert.ToDecimal(model.Protein);
            goodsComposition.Fat = Convert.ToDecimal(model.Fat);
            goodsComposition.Carb = Convert.ToDecimal(model.Carb);
            goodsComposition.B1 = Convert.ToDecimal(model.B1);
            goodsComposition.C = Convert.ToDecimal(model.C);
            goodsComposition.A = Convert.ToDecimal(model.A);
            goodsComposition.E = Convert.ToDecimal(model.E);
            goodsComposition.Ca = Convert.ToDecimal(model.Ca);
            goodsComposition.P = Convert.ToDecimal(model.P);
            goodsComposition.Mg = Convert.ToDecimal(model.Mg);
            goodsComposition.Fe = Convert.ToDecimal(model.Fe);
            return goodsComposition;
        }
    }
}
