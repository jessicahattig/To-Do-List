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
    {
      Category newCategory = new Category ("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }
  }
}