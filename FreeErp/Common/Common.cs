using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeErp.System
{

    class Common
    {
        private Dictionary<string, Location> Locations;
    }

    class Location
    {
        public string Name { get; set}

    }

    interface RouteableItem
    {
    }


    //feature: would be great to have a single approval system handling many different objects
    interface ApprovalSystem
    {
        void forwardToUser(FreeErp.Administration.User user, RouteableItem item);
        void approve(RouteableItem item);
        void cancel(RouteableItem item);
    }


    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string ZipCode { get; set; }
    }


    public class Document
    {
        public int ID { get; set; }
    }

    public class Printer
    {
        public string Name { get; set; }
    }



}
