using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using efcoredemo.Model;
using efCoredemo.Model;

namespace efCoredemo
{
    class AddCourse
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();
            var course = new Course { Title = "Python", Prereq = "Basic Programming" };
            ctx.Courses.Add(course);
            ctx.SaveChanges();
        }
    }
}
