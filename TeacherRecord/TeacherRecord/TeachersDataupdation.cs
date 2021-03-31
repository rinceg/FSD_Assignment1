using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using FSD_Assignment1;

namespace FSD_Assignment1
{
    public class TeacherDetail 
    {
        public int tId;
        public string tName;
        public string className;
        public string section;

        public TeacherDetail()
        {

        }

    }  

   

    class TeachersDataUpdation
    {
       // CustomReader customReader = new CustomReader("\\Data\\data.json");
        public string Store(TeacherDetail teacherDetail)
        {
      // C:\FSDTraining\FSD_Assignment1\TeacherRecord\TeacherRecord\Data\data.json
            var data = File.ReadAllText("Data/data.json");
            Data data1= JsonConvert.DeserializeObject<Data>(data);
            List<Data> _data = new List<Data>();
            _data.Add(new Data()
            {
                id = teacherDetail.tId,
            Class = teacherDetail.className,
            Name = teacherDetail.tName,
            Section= teacherDetail.section
        });           
            string values= JsonConvert.SerializeObject(_data);
            Console.WriteLine("Records is stored successfully..");
            File.WriteAllText("Data/data.json", values);
            return "Data is stored";
        }

        public string update(TeacherDetail teacherDetail)
        {
            List<Data> _data = new List<Data>();
            _data.Add(new Data()
            {
                id = teacherDetail.tId,
                Class = teacherDetail.className,
                Name = teacherDetail.tName,
                Section = teacherDetail.section
            });
            string values = JsonConvert.SerializeObject(_data);
            Console.WriteLine("Records is stored successfully..");
            File.WriteAllText("Data/data.json", values);
            return "Data is Updated";
        }

        public Data read()
        {
            var data = File.ReadAllText("Data/data.json");
            Data data1 = JsonConvert.DeserializeObject<Data>(data);
            List<Data> _data = new List<Data>();    
            Console.WriteLine("Records is read successfully..");         
            return data1;
        }


    }
}
