using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public static class PratricienDAO
    {
        public static PRATICIEN FindById(Int16 pranum)
        {
            //A faire : rechercher un pratricien par son numéro
            return null;
        }

        public static List<PRATICIEN> FindAll()
        {
            //A faire : charger tous les praticiens
            List<PRATICIEN> pats = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIENs.Include("LeType")
                          select p;
                pats = req.ToList<PRATICIEN>();
            }
            return pats;
        }

        public static List<PRATICIEN> FindByType(string code)
        {
            //A faire : charger tous les praticiens d'un type
            return null;
        }
    }
}
