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
      Order newOrder = new Order("Crossaint", "4", "10", "2/27/2004");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderName_ReturnsOrdersName_String()
    {
      string item = "Crossaint";
      string amount = "4";
      string price = "10";
      string date = "2/27/2004";
      Order newOrder = new Order(item, amount, price, date);
      string ItemCheck = newOrder.Item;
      Assert.AreEqual(ItemCheck, item);
    }




  }
}