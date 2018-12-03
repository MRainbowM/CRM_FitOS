using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Tariff
    {
        private int ID;
        private string Name;
        private int Duration;
        private Dictionary<DateTime, bool> Time;
        private float TotalCost;
        //private bool State;
        private DateTime StartDate;
        private DateTime ExpirationDate;
        private DateTime DateRemoved;
        //private Dictionary<int, int> AmountService;
        private Dictionary<int, int> PeriodicityService; 
    }
}
