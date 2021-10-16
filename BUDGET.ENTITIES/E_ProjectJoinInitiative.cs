using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.ENTITIES
{
    public class E_ProjectJoinInitiative
    {
        private int _idProject;
        private string _NombreProject;
        private string _DescriptionProject;
        private decimal __amountDefined;
        private string _InitiativeName;

        public int IdProject { get => _idProject; set => _idProject = value; }
        public string NombreProject { get => _NombreProject; set => _NombreProject = value; }
        public string DescriptionProject { get => _DescriptionProject; set => _DescriptionProject = value; }
        public decimal AmountDefined { get => __amountDefined; set => __amountDefined = value; }
        public string InitiativeName { get => _InitiativeName; set => _InitiativeName = value; }

    }
}
