using MVC.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Controllers;
using Microsoft.AspNetCore.Http;

namespace Test1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void DaFlechasView()
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
        [TestMethod]
        public void LoginDevuelveLoginNoAutenticado()
        {
            var controller = new AccessController();
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = new DefaultHttpContext();

            var result = controller.Login() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Login", result.ViewName);
        }
        [TestMethod]
        public void Planta1DevuelveClases()
        {
            var controller = new HomeController();

            var result = controller.Planta1() as ViewResult;
            var model = result.Model as ListaClases;

            Assert.IsNotNull(model);
            Assert.IsTrue(model.Salas.Count > 0);
        }
    }
}