using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;
using SerializationApp.Entities;

namespace SerializationApp.DeSerializationUI
{
    class Program
    {
        static object DeSerializeFromBinary()
        {
            FileStream binaryFileStream = new FileStream(@"E:\siemens_ta_22ndMarch2021\codes\day-7\SerializationApp\SerializationApp.SerializerUI\maruti.bin", FileMode.Open);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object obj = binaryFormatter.Deserialize(binaryFileStream);
            return obj;
        }
        static object DeSerializeFromSoap()
        {
            FileStream soapFileStream = new FileStream(@"E:\siemens_ta_22ndMarch2021\codes\day-7\SerializationApp\SerializationApp.SerializerUI\maruti.soap", FileMode.Open);
            SoapFormatter soapFormatter = new SoapFormatter();
            object obj = soapFormatter.Deserialize(soapFileStream);
            return obj;
        }
        static object DeSerializeFromXml()
        {
            FileStream xmlFileStream = new FileStream(@"E:\siemens_ta_22ndMarch2021\codes\day-7\SerializationApp\SerializationApp.SerializerUI\maruti.xml", FileMode.Open);
            //Type marutiType = marutiObj.GetType();

            Type marutiType = typeof(Maruti);
            Type carType = typeof(Car);
            Type audioType = typeof(AudioSystem);
            Type[] otherTypes = new Type[] { carType, audioType };
            XmlSerializer xmlFormatter = new XmlSerializer(marutiType, otherTypes);

            object obj = xmlFormatter.Deserialize(xmlFileStream);
            return obj;
        }
        static void Main()
        {
            //Maruti maruti = null;
            ////maruti = DeSerializeFromBinary() as Maruti;
            ////maruti = DeSerializeFromSoap() as Maruti;
            //maruti = DeSerializeFromXml() as Maruti;
            //Console.WriteLine(maruti);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object obj = binaryFormatter.Deserialize(new FileStream(@"E:\siemens_ta_22ndMarch2021\codes\day-7\SerializationApp\SerializationApp.SerializerUI\types.bin", FileMode.Open));
            Type[] allTypes = obj as Type[];
            foreach (Type type in allTypes)
            {
                // Console.WriteLine(type.Name);
              //object obj1 =   Activator.CreateInstance(type);
              //MethodInfo mi =  type.GetMethod("Add");
              //  mi.Invoke(obj1, new object[] { });
            }           
        }
    }
}
