using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests
  {
    [TestMethod]
    public void CategoryConstructor_CreatesInstancesOfCategory_Category()
    {
      Category newCategory = new Category ("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);
      
      //Act
      string result = newCategory.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      int result = newCategory.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    //Test failed because It says we expected to receive 1 but got an ID of 3 instead. This is because we assign each Category Id by running Id = _instances.Count; in the constructor. The third test is receiving a Category with an Id of 3 because sample Categorys created in previous tests remain in the static _instances list.
  }
}