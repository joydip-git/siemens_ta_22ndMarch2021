using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ICommon
    {
        string Path { set; get; }
    }
    interface IDataAccess : ICommon
    {
        void GetData();
    }
    interface IStorage
    {
        string Path { get; set; }
        void CreateStorage();
    }
    public class SqlDataAccess : IDataAccess, IStorage
    {
        string databasePath;
        object[] storage;
        string storagePath;

        //implicit implementation
        public void GetData()
        {
            //getting data from database as mentioned in databasePath
            Console.WriteLine("sql data");
        }

        //implicit implementation of common member from multiple interface
        //public string Path { set => databasePath = value; get => databasePath; }

        //explicit implementation of interface member
        //used when common members are inherited from multiple interfaces
        //DO NOT USE PUBLIC ACCESS SPECIFIER WITH THE INTERFACE
        //ALSO USE THE MEMBER NAME WITH THE INTERFACE NAME
        string ICommon.Path { set => databasePath = value; get => databasePath; }
        string IStorage.Path { set => storagePath = value; get => storagePath; }

        public void Print()
        {
            //code
        }

        public void CreateStorage()
        {
            storage = new object[10];
            //write this array data to a file as mentioned in the storagePath
        }
    }
    class Program
    {
        static void Main()
        {
            //invoking interface members implicitly
            SqlDataAccess sql = new SqlDataAccess();
            //since the Path property has been implemented explicitly it can only be invoked explicitly
            //sql.Path = "";
            sql.GetData();
            sql.Print(); //class's own member

            //invoking interface members explicitly
            IDataAccess dataAccess = sql; //upcasting
            //dataAccess.Path = "database path";
            //Console.WriteLine(dataAccess.Path);
            
            ICommon common = dataAccess;
            common.Path = "Common database path";
            Console.WriteLine(common.Path);
            dataAccess.GetData();
            //ERROR (you can only invoke interface members through interface reference variable)
            //dataAccess.Print();

            IStorage storage = sql;
            storage.Path = "Storage file path";
            Console.WriteLine(storage.Path);
        }
    }
}
