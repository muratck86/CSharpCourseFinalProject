using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfuly.";
        public static string InvalidProductName = "Invalid product name.";
        public static string MaintenanceTime = "Maintenance time between 00-02";
        public static string ProductsListed = "Products listed.";
        public static string ProductFound = "Product found";
        public static string ProductDetailsListed = "Product Details Listed";
        public static string CategoryAdded = "Category Added";
        public static string OrdersListed = "Orders Listed";
        public static string ProductNotFound = "Product Not Found";
        internal static string ProductDeleted;
        internal static string ProductUpdated;
        internal static string ProductNotDeleted;
    }
}
