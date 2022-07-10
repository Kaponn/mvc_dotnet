using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAppMVC.Data;
using StudentsAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAppMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly MvcStudentsContext _dbContext;

        public StudentController(MvcStudentsContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            return View(_dbContext.Students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentModel studentModel)
        {
            _dbContext.Students.Add(studentModel);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentModel studentModel)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));  
        }

        public ActionResult ChangeActiveStatus(int id)
        {
            var specificStudent = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            specificStudent.IsActive = !specificStudent.IsActive;
            _dbContext.Students.Update(specificStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Details", "Student", new { id = specificStudent.StudentId });
        }
    }
}
