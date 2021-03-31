using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonLibrary.DataAccess;
//using CommonLibrary.Drawing;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataAccess sql = new SqlDataAccess();
            Console.WriteLine(sql.GetData());

            MsAccessDataAccess ms = new MsAccessDataAccess();
            Console.WriteLine(ms.GetData());

            OracleDataAccess oracleDataAccess = new OracleDataAccess();
            Console.WriteLine(oracleDataAccess.GetData());

            //Circle circle = new Circle();
            //Console.WriteLine(circle.Draw());
        }
    }
}
