using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Trainee
    {
        private readonly int traineeId; 
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
        Trainee(int id)
        {
            traineeId = id;
        }
        //number of args
        //data type of args
        //position of args
        //parajeterized constructor
        //C# 4.0 (optional arguments with default value)
        public Trainee(int id, string name = null, string departmentName = null, double marks = 0) : this(id)
        {
            //this.traineeId;
            //traineeId = id;
            traineeName = name;
            traineeDepartmentName = departmentName;
            traineeMarks = marks;
        }
        public string GetInfo()
        {
            return "Name: " + traineeName + ", Id: " + traineeId + ", Department: " + traineeDepartmentName + ", Marks: " + traineeMarks;
        }


        //Property/Property Function
        public string TraineeDepartmentName
        {
            //public void SetDepartment(string departmentName)
            //set
            //{
            //    traineeDepartmentName = value;
            //}
            set => traineeDepartmentName = value;
            //public string GetDepartment()
            //get
            //{
            //    return traineeDepartmentName;
            //}
            get => traineeDepartmentName;
        }


        public string TraineeName
        {
            //set
            //{
            //    traineeName = value;
            //}
            //get
            //{
            //    return traineeName;
            //}
            set => traineeName = value;
            get => traineeName;
        }
        public double TraineeMarks
        {
            /*
            set
            {
                traineeMarks = value;
            }
            get
            {
                return traineeMarks;
            }
            */
            set => traineeMarks = value;
            get => traineeMarks;
        }

        //public int TraineeId
        //{
        //    //get
        //    //{
        //    //    return traineeId;
        //    //}
        //}

        //public int TraineeId
        //{        
        //    get => traineeId;
        //}
        
        //for properties with JUST GET accessor
        public int TraineeId => traineeId;
    }
}
