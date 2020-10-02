using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using _01_KomodoCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuRepo_Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            MenuItem item = new MenuItem();
            MenuRepository repository = new MenuRepository();

            //Act
            bool addResult = repository.AddMenuItemToDirectory(item);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetMenuDirectory_ShouldGetCorrectCollection()
        {
            //Arrange
            MenuItem newItem = new MenuItem();
            MenuRepository repository = new MenuRepository();
            repository.AddMenuItemToDirectory(newItem);

            //Act
            List<MenuItem> listofItems = repository.GetMenuItems();

            //Assert
            bool directoryHasContent = listofItems.Contains(newItem);
            Assert.IsTrue(directoryHasContent);

        }
        private MenuItem _item;
        private MenuRepository _repository;
        [TestMethod]
        public void DeleteExistingItem_ShouldReturnTrue()
        {
            //Arrange
            
        }
    }
}
