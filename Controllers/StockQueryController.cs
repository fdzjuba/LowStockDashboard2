using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LowStockDashboard.Controllers
{
    public class StockQueryController : ApiController
    {
        [HttpPost()]
        [ActionName("GetLowStockLevel")]
        public GetLowStockLevelResponse GetLowStockLevel(GetLowStockLevelRequest request)
        {
            System.Threading.Thread.Sleep(1000);
            List<Models.StockLevelItem> output = new List<Models.StockLevelItem>();

            LocationsController locationController = new LocationsController();
            List<Models.Location> locations = (List<Models.Location>)locationController.GetLocations();

            Models.Location location = locations.Find(s => s.LocationId == request.LocationId);
            for (int i = 0; i < request.EntriesPerPage; i++)
            {
                int newProductSuffix = (i + (request.EntriesPerPage * (request.PageNumber - 1)));
                output.Add(new Models.StockLevelItem()
                {
                    Due = i,
                    OnOrder = i,
                    Location = location.LocationName,
                    ProductTitle = "Product title " + newProductSuffix.ToString(),
                    SKU = "SKU00" + newProductSuffix.ToString(),
                    StockLevel = i
                });
            }
            return new GetLowStockLevelResponse()
            {
                TotalItems = 762,
                rows = output
            };
        }

        public class GetLowStockLevelRequest
        {
            public string LocationId;
            public int PageNumber;
            public int EntriesPerPage;
        }

        public class GetLowStockLevelResponse
        {
            public int TotalItems;
            public List<Models.StockLevelItem> rows = new List<Models.StockLevelItem>();
        }

    }
}
