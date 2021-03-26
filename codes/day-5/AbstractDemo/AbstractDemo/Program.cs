using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    //abstract class
    abstract class DataAccess
    {
        string data;
        public DataAccess()
        {

        }

        public string Data { get => data; protected set => data = value; }

        public abstract void GetData();
    }
    //concrete class
    class SqlDataAccess : DataAccess
    {
        string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public SqlDataAccess()
        {

        }
        public SqlDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public override void GetData()
        {
            //base.GetData();
            Data = "sql database data";
        }
    }
    class XmlFileDataAccess:DataAccess
    {
        string filePath;
        public XmlFileDataAccess()
        {

        }
        public XmlFileDataAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public string FilePath { get => filePath; set => filePath = value; }

        public override void GetData()
        {
            //base.GetData();
            Data = "xml data";
        }
    }
    class Program
    {
        static void GetandPrintData(DataAccess dataAccess)
        {
            dataAccess.GetData();
            Console.WriteLine(dataAccess.Data);
        }
        static void Main(string[] args)
        {
            //SqlDataAccess sqlDataAccess = new SqlDataAccess("server=.; database=;....");
            //XmlFileDataAccess xmlFileDataAccess = new XmlFileDataAccess("C:\\data.txt");
            DataAccess sqlDataAccess = new SqlDataAccess("server=.; database=;....");
            DataAccess xmlFileDataAccess = new XmlFileDataAccess("C:\\data.txt");
            GetandPrintData(sqlDataAccess);
            GetandPrintData(xmlFileDataAccess);
        }
    }
}
