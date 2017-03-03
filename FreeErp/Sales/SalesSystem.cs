using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeErp.Sales
{

    enum SalesOrderStatus
    {
        OPEN,IN_PROGRESS,CLOSED
    }

    class SalesSystem
    {

    }

    class SalesOrder
    {
        public SalesOrderStatus Status { get; set}
    }

    class SalesOrderLineItem
    {
        public Inventory.Part Product { get; set; }
    }

    class Customer
    {
        public List<System.Document> Documents;
        System.Address PhysicalAddress { get; set; }
        System.Address DeliveryAddress { get; set; }
    }



}
