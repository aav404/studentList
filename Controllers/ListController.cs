using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class ListController : Controller
    {
        private readonly StudentContext db;
        public ListController(StudentContext context)
        {
            db = context;
        }
        public IActionResult ViewStudents()
        {
            return View(db.Students.ToList());
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Redirect("~/List/ViewStudents");
        }
        public IActionResult DeleteStudent(Student student)
        {
            db.Students.Remove(student);
            db.SaveChanges();
            return Redirect("~/List/ViewStudents");
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = db.Students.First(f => f.Id == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            db.Students.Update(student);
            db.SaveChanges();
            return Redirect("~/List/ViewStudents");
        }
    }
}