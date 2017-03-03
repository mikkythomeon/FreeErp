using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeErp.Administration;
using FreeErp.System;

namespace FreeErp.Inventory
{
    public static class InventorySystem
    {
        private static Dictionary<string, Part> Parts;
        private static Dictionary<string, Warehouse> Warehouses;

        //------------------------------------------------------------------------------------------//
        //method:       get part by part number
        //purpose:      retrieves the part given a specified part number (string)
        //exception:   
        //returns:      a part object, or nothing if a matching part was not found
        //------------------------------------------------------------------------------------------//
        //method:       get part by part description
        //purpose:      retrieves the part given a portion of a part description (string)
        //exception:    
        //returns:      a list of parts which is empty if no matching parts were found.
        //------------------------------------------------------------------------------------------//
        //method:       save part
        //purpose:      adds part to collection and database, or updates if the part already exists
        //exceptions:   part state is invalid
        //returns:      null
        //------------------------------------------------------------------------------------------//
        //method:       Delete part
        //purpose:      flags the part status to inactive and conducts a series of checks to see if the part can be deleted.
        //              IF the part can be delected, then the part status is updated to Deleted
        //exceptions:   part is on existing sales order, needs to be removed first
        //              part is on existing purchase order, purchase order line to be removed first
        //              part is active on MRP forecast, needs to be removed first
        //------------------------------------------------------------------------------------------//




    }

    class Part: System.RouteableItem
    {
        public string PartNumber { get; set; }
        public string Description { get; set; }

        //a part can be stocked in multiple delivery warehouses
        
    }

    class PartApprovalSystem : System.ApprovalSystem
    {
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


    class Warehouse
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public Boolean isLocked { get; set; }


    }

    class Bin
    {

    }
}
