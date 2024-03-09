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

        public TechMapCompositionViewModel GetElement(int Id)
        {
            using var context = new SchoolCafeteriaDatabase();
            var techMapComposition = context.TechMapCompositions.FirstOrDefault(gc => gc.Id == Id);
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
            var techMapComposition = context.TechMapCompositions.FirstOrDefault(gc => gc.Id == model.Id);
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
                Id = techMapComposition.Id,
                TechnologicalMapId = techMapComposition.TechnologicalMapId,
                Protein = techMapComposition.Protein,
                Fat = techMapComposition.Fat,
                Carb = techMapComposition.Carb,
                B1 = techMapComposition.B1,
                C = techMapComposition.C,
                A = techMapComposition.A,
                E = techMapComposition.E,
                Ca = techMapComposition.Ca,
                P = techMapComposition.P,
                Mg = techMapComposition.Mg,
                Fe = techMapComposition.Fe
            };
        }

        private static TechMapComposition CreateModel(TechMapCompositionViewModel model, TechMapComposition techMapComposition)
        {
            techMapComposition.TechnologicalMapId = model.TechnologicalMapId;
            techMapComposition.Protein = model.Protein;
            techMapComposition.Fat = model.Fat;
            techMapComposition.Carb = model.Carb;
            techMapComposition.B1 = model.B1;
            techMapComposition.C = model.C;
            techMapComposition.A = model.A;
            techMapComposition.E = model.E;
            techMapComposition.Ca = model.Ca;
            techMapComposition.P = model.P;
            techMapComposition.Mg = model.Mg;
            techMapComposition.Fe = model.Fe;

            return techMapComposition;
        }
    }
}
