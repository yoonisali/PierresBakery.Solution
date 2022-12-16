using Microsoft.VisualStudio.TestTools.UnitTesting;
 using Bakery.Models;
 using System.Collections.Generic;
 using System;

 namespace Bakery.Tests
 {

   [TestClass]
   public class OrderTests : IDisposable
   {

     public void Dispose()
     {
       Vendor.ClearAll();
     }

   [TestMethod]
   public void OrderConstructor_CreateInstanceOfOrder_Order()
   {
     Order newOrder = new Order("Crossaint", "4", "10", "2/27/2004" );
     Assert.AreEqual(typeof(Order), newOrder.GetType());
   }



   }
 }