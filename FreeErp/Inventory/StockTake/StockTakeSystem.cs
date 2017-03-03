using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeErp.Administration;
using FreeErp.System;

namespace FreeErp.Inventory.StockTake
{
    class StockTakeSystem
    {


        public StockCount createStockCount(Warehouse warehouse)
        {

        }


        public StockCount createStockCount(Warehouse warehouse, List<Part> parts)
        {

        }



    }

    class StockCount:System.ApprovalSystem
    {
        private List<StockCountRecord> items;

        public void approve(RouteableItem item)
        {
            throw new NotImplementedException();
        }

        public void cancel(RouteableItem item)
        {
            throw new NotImplementedException();
        }

        public void forwardToUser(User user, RouteableItem item)
        {
            throw new NotImplementedException();
        }
    }

    class StockCountRecord
    {
        public Part part { get; set; }
        public Warehouse warehouse { get; set; }
        public Bin bin { get; set; }
        public int QtyCounted { get; set; }


    }

    

}
