using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Modified_
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugType type1 = new DrugType("headache");
            Drug drug1 = new Drug("Nimesil", 1, 5,type1);
            Drug drug2 = new Drug("Teraflu", 2, 4, type1);
            Console.WriteLine(drug1);
            drug1.DecreaseCount(6);
            Pharmacy pharmacy = new Pharmacy("Buta"){ Name="Zeferan"};
            pharmacy.ShowAllDrugs();
            Console.WriteLine(pharmacy);
        }
    }
}
