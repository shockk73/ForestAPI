using ForestInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForestInfo.Controllers
{
    public class AdminController : ApiController
    {

        public AdminController()
        {
        }

        [HttpGet]
        public IEnumerable<Forestry> GetForestries()
        {
            using (var _context = new ForestContext())
                return _context.Forestries.Where( x => x.ForestFarmCode != null ).ToList();
        }

        [HttpGet]
        public IEnumerable<ForestFarm> GetForestFarms()
        {
            using (var _context = new ForestContext())
                return _context.ForestFarms.Where(x => x.ForestryProductionAssociationCode != null).ToList();
        }


        [HttpGet]
        public IEnumerable<ForestryProductionAssociation> GetForestryProductionAssociations()
        {
            using (var _context = new ForestContext())
                return _context.ForestryProductionAssociations.Where(x => x.RegionCode != null).ToList();
        }



        [HttpGet]
        public IEnumerable<Region> GetRegions()
        {
            using (var _context = new ForestContext())
                return _context.Regions.ToList();
        }



    }
}
