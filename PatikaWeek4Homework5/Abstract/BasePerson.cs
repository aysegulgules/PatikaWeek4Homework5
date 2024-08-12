using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework5.Abstract
{
    //Kişi classı oluşturuluyor
    internal class BasePerson
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }

        internal void PersonInfo()
        {
            Console.WriteLine("Adı..: " + Name + "\nSoyadı..: " + Surname);
        }

    }

}
