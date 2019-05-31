
using HomeWork4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeWork4.Controllers
{
    public class StudentsController : ApiController
    {
        Student[] students = new Student[] {
            new Student { Sid = 1, Age = 18, Sname = "王一朵", Major = "软件工程", Class = "4" },
            new Student { Sid = 2, Age = 19, Sname = "田成", Major = "软件工程", Class = "4" },
            new Student { Sid = 3, Age = 19, Sname = "姚程", Major = "化工", Class = "1" },
            new Student { Sid = 4, Age = 17, Sname = "李莉莉", Major = "理学院", Class = "3" },
            new Student { Sid = 5, Age = 20, Sname = "杨一鸣", Major = "化工", Class = "2" }
        };

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public IHttpActionResult GetPlayer(int id)
        {
            var students = this.students.FirstOrDefault(p => p.Sid == id);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
    }
}