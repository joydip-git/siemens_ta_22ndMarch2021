using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SerializationApp.Entities;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;

namespace SerializationApp.SerializerUI
{
    class Program
    {
        static void SerializeInBinary(Maruti marutiObj)
        {
            FileStream binaryFileStream = new FileStream(@"../../maruti.bin", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(binaryFileStream, marutiObj);
        }
        static void SerializeInSoap(Maruti marutiObj)
        {
            FileStream soapFileStream = new FileStream(@"../../maruti.soap", FileMode.OpenOrCreate);
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(soapFileStream, marutiObj);
        }
        static void SerializeInXml(Maruti marutiObj)
        {
            FileStream xmlFileStream = new FileStream(@"../../maruti.xml", FileMode.OpenOrCreate);
            //Type marutiType = marutiObj.GetType();

            Type marutiType = typeof(Maruti);
            Type carType = typeof(Car);
            Type audioType = typeof(AudioSystem);
            Type[] otherTypes = new Type[] { carType, audioType };
            XmlSerializer xmlFormatter = new XmlSerializer(marutiType, otherTypes);

            xmlFormatter.Serialize(xmlFileStream, marutiObj);
        }
        static void Main()
        {            
            AudioSystem sonyAudio = new AudioSystem("Sony Audio 5", "Sony");
            Maruti wagonR = new Maruti("WagonR VXI", "Grey", true, "Maruti", sonyAudio, false);
            //SerializeInBinary(marutiObj: wagonR);
            //SerializeInSoap(wagonR);
            SerializeInXml(wagonR);
        }
    }
}
