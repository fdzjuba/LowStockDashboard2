using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LowStockDashboard.Controllers
{
    public class LocationsController : ApiController
    {
        [HttpGet()]
        [ActionName("GetLocations")]
        public IEnumerable<Models.Location> GetLocations()
        {
            System.Threading.Thread.Sleep(1000);

            List<Models.Location> locations = new List<Models.Location>();            

            locations = new List<Models.Location>();
            locations.Add(new Models.Location()
            {
                LocationId = "1",
                LocationName = "Warehouse 1"
            });
            locations.Add(new Models.Location()
            {
                LocationId = "2",
                LocationName = "US Warehouse 2"
            });
            locations.Add(new Models.Location()
            {
                LocationId = "3",
                LocationName = "East Asia"
            });
            return locations;
        }
    }
}
