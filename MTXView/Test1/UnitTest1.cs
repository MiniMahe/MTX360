using MVC.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Controllers;

namespace Test1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Flechas_ReturnsViewResult()
		{
			// Arrange
			var controller = new HomeController();

			// Act
			var result = controller.Flechas();

			// Assert
			Assert.IsInstanceOfType(result, typeof(ViewResult));
		}

		[TestMethod]
		public void Flechas_ReturnsArrowsModelInViewResult()
		{
			// Arrange
			var controller = new HomeController();

			// Act
			var result = controller.Flechas() as ViewResult;

			// Assert
			Assert.IsInstanceOfType(result.Model, typeof(Arrows));
		}

		[TestMethod]
		public void Flechas_ReturnsArrowsModelWithCorrectData()
		{
			// Arrange
			var controller = new HomeController();

			// Act
			var result = controller.Flechas() as ViewResult;
			var model = result.Model as Arrows;

			// Assert
			Assert.IsNotNull(model);
			Assert.AreEqual(model.list.Count, 3); // Assuming there are 3 arrows in the database
			Assert.AreEqual(model.list[0].id, 1); // Assuming the first arrow has an id of 1
			Assert.AreEqual(model.list[0].id_image, "arrow.png"); // Assuming the first arrow's image is "arrow.png"
			Assert.AreEqual(model.list[0].nodeid, 1); // Assuming the first arrow's nodeid is 1
			Assert.AreEqual(model.list[0].posicion, "top"); // Assuming the first arrow's position is "top"
		}
	}
}