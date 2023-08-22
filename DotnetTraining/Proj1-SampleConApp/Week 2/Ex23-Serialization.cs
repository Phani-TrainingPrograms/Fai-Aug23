using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Proj1_SampleConApp.Week_2
{
    [Serializable]//Not required for XML and SOAP Serialization. 
    public class Data
    {
        public int DataNo { get; set; }
        public string DataName { get; set; }
        public DateTime BillDate { get; set; } = DateTime.Now;
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"Amount of Rs. {Amount} has been spent for {DataName} on {BillDate.ToLongDateString()}";
        }
    }

    class Ex23_Serialization
    {
        static void Main(string[] args)
        {
            //serialization();
            //deserialization();

            //Todo: Implement the IEmpDatabase interface in a class that uses serialization as the basis of storing the data. 

            //xmlSerialization();
            XmlDeserialization();
            //toDo: Create an Enum called SerializationMode  which has values of Binary, XML and SOAP, allow the user to choose the format and make UR App save in that manner. 
        }

        private static void XmlDeserialization()
        {
            FileStream fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer fm = new XmlSerializer(typeof(Data));
            Data extracted = fm.Deserialize(fs) as Data;
            Console.WriteLine(extracted.ToString());
        }

        private static void xmlSerialization()
        {
            Data data = createData();
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer fm = new XmlSerializer(typeof(Data));
            fm.Serialize(fs, data);
            fs.Close();
        }

        private static void deserialization()
        {
            FileStream fs = new FileStream("Temp.Bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter fm = new BinaryFormatter();
            Data deserializedData = fm.Deserialize(fs) as Data;
            Console.WriteLine(deserializedData.DataName);
        }

        private static void serialization()
        {
            Data dt = createData();//What to serialize....
            string fileLocation = "Temp.Bin";
            //Where to serialize....
            FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate, FileAccess.Write);
            //Binary Serialization for saving...
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, dt);
            fs.Close();
        }

        private static Data createData()
        {
            int id = 123;
            string name = "Food at Cafeteria";
            int amount = 250;
            DateTime dt = DateTime.Now.AddDays(-146);

            return new Data
            {
                Amount = amount,
                DataName = name,
                DataNo = id,
                BillDate = dt
            };
        }
    }
}
