using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Budzet_domowy.Classes;
using Budzet_domowy.Classes.BuisnessLogic;

namespace Budzet_domowy
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlStorageTypes.Register<User>();

            var budget = new Budget("Budżet domowy", "Nowy budżet domowy");
            budget.AddCost(100);
            budget.AddCost(240);
            budget.AddCost(50);


            budget.AddIncome(2100);
            budget.AddIncome(2540);
            budget.AddIncome(900);

            var costs = new List<double>() { 320.4, 45.4, 99.05 };
            var allIncome = new List<double>() { 320.4, 45.4, 99.05 };


            var result = 0.0;
            foreach (var cost in costs)
            {

                result += cost;
            }
            result /= costs.Count;
            Console.WriteLine($"Średnia kosztu to {result:N1}");



        }
    }
}
