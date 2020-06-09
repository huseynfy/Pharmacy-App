using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Modified_
{
    class Drug
    {
        private static int _id;
        public string Name;
        public DrugType Type;
        public int Price;
        private int Count;
        public int Id;

        public Drug(string name, int price,int count, DrugType type)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
            Type = type;
        }
        public override string ToString()
        {
            return $"Name:{Name} Price:{Price} Count: {Count} Type: {Type}";
        }
        public void IncreaseCount(int count)
        {
            Count += count;
        }
        public void DecreaseCount(int count)
        {
            if (Count >= count)
            {
                Count -= count;
            }
            else
            {
                Console.WriteLine($"{count} can not give this amount of drug. Remaining count is {Count}");
            }
        }
    }
}
