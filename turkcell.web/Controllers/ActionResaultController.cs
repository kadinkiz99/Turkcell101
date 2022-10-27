using Microsoft.AspNetCore.Mvc;

namespace turkcell.web.Controllers
{
	public class ActionResaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		// sayfada kontrol ederken == /Actionresault/contentresault
		//geriye string değer döndürmek için kullanılır 
		public IActionResult ContentResault()
		{

			return Content("Content Resault");
		}

		// geriye json çıktısı dönderir.
		//Actionresault/jsonetresault
		public IActionResult JsonResault()
		{

			return Json(new { Id = 3 , name="Kalem" , Price = 200});
		}

		// geriye boş sayfa  dönderir.
		//Actionresault/emptyresault
		public IActionResult EmptyResault()
		{

			return new EmptyResult();
		}
	}
}
