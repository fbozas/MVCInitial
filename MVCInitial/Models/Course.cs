using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInitial.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }

    }
}