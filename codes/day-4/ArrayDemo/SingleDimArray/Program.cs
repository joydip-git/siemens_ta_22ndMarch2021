using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimArray
{
    class Program
    {
        static void Main()
        {
            //IntSingleArray();

            //StringSingleArray();
        }
        private static void TraineeSingleArray()
        {
            //Trainee[] trainees = new Trainee[3];
            //trainees[0] = new Trainee(....);
            //trainees[1] = new Trainee(....);
            //trainees[2] = new Trainee(....);
            //for (int index = 0; index < trainees.Length; index++)
            //{
            //    Trainee traineeRef = trainees[index];
            //    CW(traineeRef.TraineeName);
            //}
        }
        private static void StringSingleArray()
        {
            string[] places = new string[3];
            places[0] = "Bangalore";
            places[1] = "Chennai";
            places[2] = "Pune";

            for (int index = 0; index < places.Length; index++)
            {
                Console.WriteLine(places[index]);
            }
        }

        private static void IntSingleArray()
        {
            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            for (int index = 0; index < arr.Length; index++)
            {
                Console.WriteLine($"Value at arr[{index}]={arr[index]}");
            }
        }
    }
}
