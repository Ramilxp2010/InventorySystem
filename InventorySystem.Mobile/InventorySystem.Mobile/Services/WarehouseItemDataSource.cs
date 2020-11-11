using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Api;
using InventorySystem.Contract;

namespace InventorySystem.Mobile.Services
{
    public class WarehouseItemDataSource
    {
        List<WarehouseProduct> items;
        ApiManager api;

        public WarehouseItemDataSource(ApiManager api)
        {
            items = api.GetWarehouseProducts();
        }
        
        public async Task<IEnumerable<WarehouseProduct>> GetWarehouseProductsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
