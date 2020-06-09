using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Modified_
{
    class Pharmacy
    {
        private static int _id;
        public string Name;
        public int Id;
        private Drug[] drugs = { };

        public Pharmacy(string name)
        {
            _id++;
            Id = _id;
            Name = name;
        }

        public void ShowAllDrugs()
        {
            foreach (Drug drug in drugs)
            {
                Console.WriteLine(drug);
            }
        }
        public override string ToString()
        {
            return Name;
        }

  
    }
}
