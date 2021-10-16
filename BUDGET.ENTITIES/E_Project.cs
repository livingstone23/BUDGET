using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.ENTITIES
{
    public class E_Project
    {
        private int _idProject;
        private string _nameProject;
        private string _descripcionProject;
        private decimal _Amount;
        private int _idIniciativa;
        private string _nombreIniciativa;

        public int IdProject { get => _idProject; set => _idProject = value; }
        public string NameProject { get => _nameProject; set => _nameProject = value; }
        public string DescripcionProject { get => _descripcionProject; set => _descripcionProject = value; }
        public decimal Amount { get => _Amount; set => _Amount = value; }
        public int IdIniciativa { get => _idIniciativa; set => _idIniciativa = value; }
        public string NombreIniciativa { get => _nombreIniciativa; set => _nombreIniciativa = value; }

    }
}
