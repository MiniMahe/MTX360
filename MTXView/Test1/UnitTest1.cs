using MVC.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Controllers;

namespace Test1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void DaFlechasAlaView()
		{
			var controller = new HomeController();
			var result = controller.Flechas();
			Assert.IsInstanceOfType(result, typeof(ViewResult));
		}

		[TestMethod]
		public void DevolucionFlechasAlModelo()
		{ 
			var controller = new HomeController();
			var result = controller.Flechas() as ViewResult;
			Assert.IsInstanceOfType(result.Model, typeof(Arrows));
		}
	}
}