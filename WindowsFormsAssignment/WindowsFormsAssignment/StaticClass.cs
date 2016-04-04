using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;

namespace WindowsFormsAssignment
{
    public class StaticClass
    {
        public static StaticClass sc;

        List<string> enrolType = new List<string>() { "Full Time", "Part Time" };
        public static StaticClass getInstance()
        {
            if (sc == null)
            {
                sc = new StaticClass();
            }
            return sc;
        }

        public List<Student> studentList = new List<Student>();



    }
    }
