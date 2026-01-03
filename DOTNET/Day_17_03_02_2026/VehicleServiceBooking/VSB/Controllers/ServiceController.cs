using Microsoft.AspNetCore.Mvc;
using VSB.DAL;
using VSB.Models;

namespace VSB.Controllers
{

    [Route("Service")]
    public class Service : Controller
    {
        private readonly VSDbUtil _vsdb;

        public Service(VSDbUtil vsdb)
        {
            _vsdb = vsdb;
        }

        [HttpGet]
        [Route("AllService")]
        public IActionResult VehicleServices()
        {
            var allServices = _vsdb.vehicleservices.ToList();
            if (allServices.Count == 0)
            {
                TempData["ErrMsg"] = "Currenty no Services Available";
                return View();
            }

            return View(allServices);
        }

        [HttpGet]
        [Route("AddService")]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        [Route("AddService")]
        public IActionResult InsertService(VehicleService service)
        {
            _vsdb.vehicleservices.Add(service);
            _vsdb.SaveChanges();
            TempData["SuccessMsg"] = "Service added successfully";
            return RedirectToAction("AllService");
        }

        [HttpGet]
        [Route("Edit/{id:int}")]
        public IActionResult EditPage(int id)
        {
            VehicleService service = _vsdb.vehicleservices.Find(id);
            return View(service);

        }

        [HttpPost]
        [Route("Edit/{id:int}")]
        public IActionResult Edit(int id, VehicleService s)
        {
            VehicleService service = _vsdb.vehicleservices.Find(id);

            service.SName = s.SName;
            service.SDuration = s.SDuration;
            service.SPrice= s.SPrice;

            _vsdb.vehicleservices.Update(service);

            _vsdb.SaveChanges();
            return RedirectToAction("AllService");

        }
        [HttpGet]
        [Route("Delete/{id:int}")]
        public IActionResult Delete(int id, VehicleService s)
        {
            VehicleService service = _vsdb.vehicleservices.Find(id);

            _vsdb.vehicleservices.Remove(service);


            _vsdb.SaveChanges();
            return RedirectToAction("AllService");
        }

        }
    }
