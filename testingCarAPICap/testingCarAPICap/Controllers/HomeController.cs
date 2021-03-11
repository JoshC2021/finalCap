using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testingCarAPICap.Models;

namespace testingCarAPICap.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarDAL _carDAL = new CarDAL();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllCars()
        {
            List<Car> carList = _carDAL.ReturnAll();
            return View(carList);
        }

        public IActionResult Search(string make, string model, string year, string color)
        {
            String[] searchParams = { make, model, year, color };
            List<Car> carSearch = new List<Car>();
            int usedParams = 0;
            for (int i =0;i<searchParams.Length;i++)
            {
                // skip searching params that are null
                if(searchParams[i] is null)
                {
                    continue;
                }

                // refining initial list with additonal params
                if (usedParams > 0)
                {
                    carSearch = carSearch.Where(x => x.ToString().ToLower().Contains(searchParams[i].ToLower())).ToList();
                }

                // creates initial list, clears input by refreshing page if no cars found
                if (usedParams == 0)
                {
                    try
                    {
                        switch (i)
                        {
                            case 0:
                                carSearch.AddRange(_carDAL.ReturnSearch("Make", searchParams[i]));
                                break;
                            case 1:
                                carSearch.AddRange(_carDAL.ReturnSearch("Model", searchParams[i]));
                                break;
                            case 2:
                                carSearch.AddRange(_carDAL.ReturnSearch("Year", searchParams[i]));
                                break;
                            case 3:
                                carSearch.AddRange(_carDAL.ReturnSearch("Color", searchParams[i]));
                                break;
                        }
                        usedParams++;
                    }
                    catch
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            
            // check to see if search params matched anything
            if (carSearch.Count <= 0)
            {
                return RedirectToAction("Index");
            }
            return View(carSearch);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
