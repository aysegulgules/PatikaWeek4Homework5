using PatikaWeek4Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework5.Concrete
{
    //Öğretmen classı oluşturuluyor
    internal class Teacher: BasePerson //BasePerseon classından miras(Inheritance) alıyor.
    {
        internal double TeacherSalary { get; set; }

        internal void TeacherInfo()
        {
            Console.Write("Öğretmen-----------\n");
            PersonInfo();
            Console.WriteLine("Maaşı..:" + TeacherSalary);
        }
    }
}
