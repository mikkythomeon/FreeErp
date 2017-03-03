using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeErp.Administration;
using FreeErp.System;

namespace FreeErp.ProductionPlanning
{
    class ProductionPlanningSystem
    {

        /// <summary>
        /// creates a copy of an MPS and flags it as in progress
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public MasterProductionPlan checkOutMPSVersion(string version)
        {

        }

        /// <summary>
        /// sets the MPS as the active MPS, increements the revision number, and deactivates any existing MPS
        /// </summary>
        /// <param name="mps"></param>
        public void activateMPS(MasterProductionPlan mps)
        {

        }

        public void runMRPCalculation()
        {

        }



    }


    class MasterProductionPlan : System.ApprovalSystem
    {
        //an MPS must be routed to managers for approval
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

    class MasterProductionPlanRecord
    {
        DateTime RequiredDate { get; set; }
        double QtyRequired { get; set; }
        Inventory.Part part { get; set; }
    }



}
