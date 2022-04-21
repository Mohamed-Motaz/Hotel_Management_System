using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Clinic.Models
{
    class TestClass
    {
        public string Name { get; set; }
        public string Adres { get; set; }


        public TestClass(string name, string adress)
        {
            Name = name;
            Adres = adress;
        }
    }
}
