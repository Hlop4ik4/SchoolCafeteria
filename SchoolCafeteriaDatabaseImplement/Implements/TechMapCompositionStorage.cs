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
    public class TechMapCompositionStorage
    {
        public List<TechMapCompositionViewModel> GetFullList()
        {
            using var context = new SchoolCafeteriaDatabase();
            return context.TechMapCompositions
                .Select(CreateModel)
                .ToList();
        }

        public TechMapCompositionViewModel GetElementByTechMapId(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var techMapComposition = context.TechMapCompositions.FirstOrDefault(gc => gc.TechnologicalMapId == Id);
            return techMapComposition != null ? CreateModel(techMapComposition) : null;
        }

        public void Insert(TechMapCompositionViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();

            context.TechMapCompositions.Add(CreateModel(model, new TechMapComposition()));
            context.SaveChanges();
        }

        public void Update(TechMapCompositionViewModel model)
        {
            if (model == null)
            {
                return;
            }

            using var context = new SchoolCafeteriaDatabase();
            var techMapComposition = context.TechMapCompositions.FirstOrDefault(gc => gc.Id == Convert.ToInt32(model.Id));
            if (techMapComposition == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, techMapComposition);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var techMapComposition = context.TechMapCompositions.FirstOrDefault(gc => gc.Id == Id);
            if (techMapComposition == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.TechMapCompositions.Remove(techMapComposition);
            context.SaveChanges();
        }

        private static TechMapCompositionViewModel CreateModel(TechMapComposition techMapComposition)
        {
            return new TechMapCompositionViewModel
            {
                Id = Convert.ToString(techMapComposition.Id),
                TechnologicalMapId = Convert.ToString(techMapComposition.TechnologicalMapId),
                Protein = Convert.ToString(techMapComposition.Protein),
                Fat = Convert.ToString(techMapComposition.Fat),
                Carb = Convert.ToString(techMapComposition.Carb),
                B1 = Convert.ToString(techMapComposition.B1),
                C = Convert.ToString(techMapComposition.C),
                A = Convert.ToString(techMapComposition.A),
                E = Convert.ToString(techMapComposition.E),
                Ca = Convert.ToString(techMapComposition.Ca),
                P = Convert.ToString(techMapComposition.P),
                Mg = Convert.ToString(techMapComposition.Mg),
                Fe = Convert.ToString(techMapComposition.Fe)
            };
        }

        private static TechMapComposition CreateModel(TechMapCompositionViewModel model, TechMapComposition techMapComposition)
        {
            techMapComposition.TechnologicalMapId = Convert.ToInt32(model.TechnologicalMapId);
            techMapComposition.Protein = Convert.ToDecimal(model.Protein);
            techMapComposition.Fat = Convert.ToDecimal(model.Fat);
            techMapComposition.Carb = Convert.ToDecimal(model.Carb);
            techMapComposition.B1 = Convert.ToDecimal(model.B1);
            techMapComposition.C = Convert.ToDecimal(model.C);
            techMapComposition.A = Convert.ToDecimal(model.A);
            techMapComposition.E = Convert.ToDecimal(model.E);
            techMapComposition.Ca = Convert.ToDecimal(model.Ca);
            techMapComposition.P = Convert.ToDecimal(model.P);
            techMapComposition.Mg = Convert.ToDecimal(model.Mg);
            techMapComposition.Fe = Convert.ToDecimal(model.Fe);

            return techMapComposition;
        }
    }
}
