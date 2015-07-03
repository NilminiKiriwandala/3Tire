using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public class Student
    {
        
        public static int id = 1;


        public string ID { get; set; }

        public string GetNewID()
        {
            ID =  "ST:" + id++;
            return ID;
        }      

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public double GPA { get; set; }

        public bool Active { get; set; }

        public static List<Student> GetStudentList()
        {
            List<Student> result = new List<Student>();
            DataAccess.RegistrationTable itemTable = new DataAccess.RegistrationTable();
            DataSet data = itemTable.Read();
            foreach (DataRow dataRow in data.Tables[0].Rows)
            {
                result.Add(new Student(){
                    ID = dataRow["ID"].ToString(),
                    Name = dataRow["Name"].ToString(),
                    DOB = DateTime.Parse(dataRow["DOB"].ToString()),
                    GPA = double.Parse(dataRow["GPA"].ToString()),
                    Active = (bool)dataRow["Active"]
                });
                
            }
            return result;
        }

        public static void SaveList(List<Student> students)
        {
            DataAccess.RegistrationTable itemTable = new DataAccess.RegistrationTable();
            DataSet data = itemTable.Read();
            foreach (var student in students)
            {
                itemTable.Save(new object[] {student.ID, student.Name, student.DOB, student.GPA, student.Active });

            }

        }
    }
}
