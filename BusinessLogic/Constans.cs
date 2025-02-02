using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Constans
    {
        //Role constans
        public static string Role_Admin = "Admin";
        public static string Role_Client = "Client";

        // Payment Status constans
        public static string PaymentStatus_Approved = "Approved";
        public static string PaymentStatus_Pending = "Pending";
        public static string PaymentStatus_Rejected = "Rejected";

        // Order Status constans
        public static string OrderStatus_Retrieved = "Retrieved";
        public static string OrderStatus_Reserved = "Reserved";
        public static string OrderStatus_Pending = "Pending";
        public static string OrderStatus_Rejected = "Rejected";
        public static string OrderStatus_Cancelled = "Cancelled";
        public static string OrderStatus_Refunded = "Refunded";
    }
}
