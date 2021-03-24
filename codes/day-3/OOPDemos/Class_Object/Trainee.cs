using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Trainee
    {
        private int traineeId;
        private double traineeMarks;
        private string traineeName;
        private string traineeDepartmentName;

        //default parameterless constructor
        public Trainee()
        {
            //int x = 19;
            //traineeId = 0;
            //traineeMarks = 0;
            //traineeName = null;
            //traineeDepartmentName = null;
        }
        //number of args
        //data type of args
        //position of args
        //parajeterized constructor
        public Trainee(int id, string name, string departmentName, double marks) : this()
        {
            //this.traineeId;
            traineeId = id;
            traineeName = name;
            traineeDepartmentName = departmentName;
            traineeMarks = marks;
        }
        public string GetInfo()
        {
            return "Name: " + traineeName + ", Id: " + traineeId + ", Department: " + traineeDepartmentName + ", Marks: " + traineeMarks;
        }
    }
}
