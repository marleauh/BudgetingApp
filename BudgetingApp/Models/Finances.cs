using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingApp.Models
{
    internal class Finances
    {
        public string FinanceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Wage { get; set; }
        public double Mortgage { get; set; }
        public double Rent { get; set; }
        public double WaterBill { get; set; }
        public double GasBill { get; set; }
        public double FuelBill { get; set; }
        public double ElectricBill { get; set; }
        public double GroceryBill { get; set; }
        public double OtherExpense { get; set; }
    }
}
