using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.ENTITIES
{
    public class E_Initiative
    {
        private int _IdInitiative;
        private string _InitiativeName;
        private string _InitiativeDescription;

        public int IdInitiative { get => _IdInitiative; set => _IdInitiative = value; }
        public string InitiativeName { get => _InitiativeName; set => _InitiativeName = value; }
        public string InitiativeDescription { get => _InitiativeDescription; set => _InitiativeDescription = value; }
    }
}
