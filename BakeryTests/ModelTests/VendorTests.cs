using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{

  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Bob's Bakery", "Texas");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorName_ReturnsVendorsName_String()
    {
      string name = "Bob's Bakery";
      string location = "Texas";
      Vendor newVendor = new Vendor(name, location);
      string nameOfVendor = newVendor.Name;
      Assert.AreEqual(nameOfVendor, name);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name = "Bob's Bakery";
      string location = "Texas";
      string name2 = "Larry's Bakery";
      string location2 = "Alaska";
      Vendor newVendor = new Vendor(name, location);
      Vendor newVendor2 = new Vendor(name2, location2);
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }



  }
}