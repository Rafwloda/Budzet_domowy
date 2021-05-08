using System;
using System.Collections.Generic;
using System.Text;

namespace Budzet_domowy.Classes.BuisnessLogic
{
    class Budget
    {
        public Budget(string budget_name, string budget_description)
        {
            costs = new List<double>();
            allIncome = new List<double>();
            this.budget_name = budget_name;
            this.budget_description = budget_description;
        }

        public void AddCost(double cost)
        {
            costs.Add(cost);
        }

        public void AddIncome(double income)
        {
            allIncome.Add(income);
        }

        private List<double> costs;
        private List<double> allIncome;
        private string budget_name;
        private string budget_description;

        //public int budget_id;
        //public string budget_name;
        //public string budget_desc;
        //public int cost_ID;
        //public int income_ID;





    }


    


}

