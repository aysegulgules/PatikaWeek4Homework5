using PatikaWeek4Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework5.Concrete
{
    //Öğrenci classı oluşturuluyor
    internal class Student: BasePerson //BasePerseon classından miras(Inheritance) alıyor.
    {
        internal int StudentNumber { get; set; }

        internal void StudentInf()
        {
            Console.Write("\nÖğrenci-------------------\n");
            Console.WriteLine("Numarası..:" + StudentNumber);
            PersonInfo();
            
        }
    }
}
