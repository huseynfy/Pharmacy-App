using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Modified_
{
    public class DrugType
    {
        private static int _id;
        public string Name;
        public int Id;

        public DrugType(string name)
        {
            _id++;
            Id = _id;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
