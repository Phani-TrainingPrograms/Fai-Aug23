using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;
using System.IO;

namespace Proj1_SampleConApp.Models
{
    class EmpBinaryDatabase : IEmpDatabase
    {
        List<Employee> _list = new List<Employee>();
        public Employee this[int index] => throw new NotImplementedException();

        private readonly string fileName = ConfigurationManager.AppSettings["binaryFile"];
        //To save the _list thru binary serialization...
        private void save()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, _list);
            fs.Close();
        }
        //To load the _list thru binary deserialization...
        private void load()
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter fm = new BinaryFormatter();
            _list = fm.Deserialize(fs) as List<Employee>;
            fs.Close();
        }
        public int Count => throw new NotImplementedException();

        public void AddEmployee(Employee emp)
        {
            load();
            _list.Add(emp);
            save();
        }

        public void DeleteEmployee(int id)
        {
            load();
            var foundRec = _list.Find(delegate (Employee temp)
            {
                return temp.EmpId == id;
            });
            if(foundRec != null)
            {
                _list.Remove(foundRec);
            }
            save();
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public void UpdateEmployee(int id, Employee emp)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
