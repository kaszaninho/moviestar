namespace HelperProject
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

        public static string[] PaymentStatuses = [PaymentStatus_Approved, PaymentStatus_Pending, PaymentStatus_Rejected];

        // Order Status constans
        public static string OrderStatus_Retrieved = "Retrieved";
        public static string OrderStatus_Reserved = "Reserved";
        public static string OrderStatus_Pending = "Pending";
        public static string OrderStatus_Rejected = "Rejected";
        public static string OrderStatus_Cancelled = "Cancelled";
        public static string OrderStatus_Refunded = "Refunded";

        // Stripe Coupons IDs
        public static string Stripe_Coupon_MOVIE5_id = "HRao2Wzn";
        public static string Stripe_Coupon_MOVIE20_id = "HLdbkBDK";
    }
}
