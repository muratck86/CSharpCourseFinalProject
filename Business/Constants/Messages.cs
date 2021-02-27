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
        public static string ProductDeleted = "Product successfuly deleted.";
        public static string ProductUpdated = "Product successfuly updated.";
        public static string ProductNotDeleted = "Product name can't start with a number";
        public static string OrderDateRequired = "Order date can't be empty.";
        public static string InvalidProductNameStartsWithNumber = "Product name cannot start with numbers";
        public static string MaxProductCountReached = "Maximum product number for this category reached";
        public static string SameNamedProductExists ="Product name already exists.";
        public static string CategoryLimitExceeded = "Category limit reached";
        public static string CategoryRemoved = "Category Removed";
        public static string CategoryUpdated = "Category Updated";
        public static string CustomerUpdated = "Customer Updated";
        public static string CustomerRemoved = "Customer Removed";
        public static string OrderRemoved = "Order Removed";
        public static string OrderUpdated = "Order Updated";
    }
}
