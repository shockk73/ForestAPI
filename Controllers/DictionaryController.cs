using ForestInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForestInfo.Controllers
{
    public class DictionaryController : ApiController
    {

        public DictionaryController()
        {
        }

        [HttpGet]
        public IEnumerable<Breed> GetTreeBreeds([FromUri] int all = 0)
        {
            using (var _context = new ForestContext())
                return _context.Breeds.Where( b => b.Code < 400000 && (all == 1 || b.Code % 100 == 0) ).ToList();
        }

        [HttpGet]
        public IEnumerable<GroundCover> GetGroundCoverKinds()
        {
            using (var _context = new ForestContext())
                return _context.GroundCovers.ToList();
        }

        [HttpGet]
        public IEnumerable<Breed> GetUndergrowthBreeds([FromUri] int all = 0)
        {
            using (var _context = new ForestContext())
                return _context.Breeds.Where(b => b.Code > 400000 && (all == 1 || b.Code % 100 == 0)).ToList();
        }

    }
}
