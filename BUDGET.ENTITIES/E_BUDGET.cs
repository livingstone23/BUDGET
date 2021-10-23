using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.ENTITIES
{
    public class E_BUDGET
    {
        private int _IdInitiative;
        private string _InitiativeName;
        private int _IdProject;
        private string _ProjectName;
        private decimal amountInvoiced;
        private decimal pOsReceived;
        private decimal balance;
        private decimal adjustment;
        private decimal finalBalance;
        private string notes;

        private string totalInitiative;
        private string totalProjects;
        private string totalPos;

        public int IdInitiative { get => _IdInitiative; set => _IdInitiative = value; }
        public string InitiativeName { get => _InitiativeName; set => _InitiativeName = value; }
        public int IdProject { get => _IdProject; set => _IdProject = value; }
        public string ProjectName { get => _ProjectName; set => _ProjectName = value; }
        public decimal AmountInvoiced { get => amountInvoiced; set => amountInvoiced = value; }
        public decimal POsReceived { get => pOsReceived; set => pOsReceived = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Adjustment { get => adjustment; set => adjustment = value; }
        public decimal FinalBalance { get => finalBalance; set => finalBalance = value; }
        public string Notes { get => notes; set => notes = value; }
        

        public string TotalInitiative { get => totalInitiative; set => totalInitiative = value; }
        public string TotalProjects { get => totalProjects; set => totalProjects = value; }
        public string TotalPos { get => totalPos; set => totalPos = value; }
    }
}
