using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeErp.Administration;
using FreeErp.System;

namespace FreeErp.Purchasing
{

    enum RequisitionStatus
    {
        OPEN , WAITING_FOR_APPROVAL, APPROVED,REJECTED,CLOSED
    }

    enum PurchaseOrderStatus
    {
        OPEN,SENT_TO_SUPPLIER,CLOSED
    }

    class PurchasingSystem
    {





    }

    class Requisition: System.RouteableItem
    {
        public Supplier supplier { get; set; }
        public List<RequisitionLineItem> RequisitionLineItem { get; }
        public RequisitionStatus Status { get; set; }
    }


    class PurchaseOrderApprovalSystem: System.ApprovalSystem
    {

        public void forwardToUser(FreeErp.Administration.User user, System.RouteableItem item)
        {

        }

        public void approve(System.RouteableItem item)
        {

        }

        public void cancel(System.RouteableItem item)
        {

        }

    }


    class SupplierApprovalSystem : System.ApprovalSystem
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



    //create one line item for PO line items and requisition items
    //makes it easier to track
    class RequisitionLineItem
    {
        public FreeErp.Inventory.Part part { get; set; }
        public Double QuantityRequired { get; set; }
        public Double QuantityReceived { get; set; }
        public DateTime RequiredDate { get; set; }
    }

    class PurchaseOrder
    {
        public Requisition requisition { get; set; }
        public PurchaseOrderStatus Status { get; set; } 
        public int ID { get; set; }
    }

    class Supplier: System.RouteableItem
    {
        public List<System.Document> Documents;
        System.Address PhysicalAddress { get; set; }
        System.Address DeliveryAddress { get; set; }
        public string SupplierName { get; set; }
        

    }


}
