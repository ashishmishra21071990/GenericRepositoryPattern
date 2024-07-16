using GenericRepostoryPatternCore.Contract;
using GenericRepostoryPatternCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepostoryPatternCore.Controllers
{
    public class SchoolController : Controller
    {
        private IGeneric<School> _school;
        public SchoolController(IGeneric<School> school)
        {
            _school = school;
        }
        public IActionResult Index()
        {
            var schools = _school.GetAll();
            return View(schools);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(School scObj)
        {
            bool b=_school.Add(scObj);
            if (b == true)
            {
                TempData["insert"] = "<script>alert('School Added SuccessFully!!');</script>";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["insert"] = "<script>alert('School Failed!!');</script>";
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            School school=_school.GetByID(id);
            return View(school);
        }
        [HttpPost]
        public IActionResult Edit(School scObj)
        {
            bool b = _school.Update(scObj);
            if (b == true)
            {
                TempData["update"] = "<script>alert('School Updated SuccessFully!!');</script>";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["update"] = "<script>alert('School Failed!!');</script>";
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            School school = _school.GetByID(id);
            return View(school);
        }
        public IActionResult Delete(int id)
        {
            School school = _school.Delete(id);
            if (school != null)
            {
                TempData["delete"] = "<script>alert('School Deleted SuccessFully!!');</script>";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["delete"] = "<script>alert('School Failed!!');</script>";
            }
            return View(school);
        }
    }
}
