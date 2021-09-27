using BUDGET.DATA;
using BUDGET.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.BUSINESS
{
    public class N_Initiative
    {
        D_Initiative objDato = new D_Initiative();

        public List<E_Initiative> ListInitiative(string buscar)
        {
            return objDato.ListInitiative(buscar);
        }

        public void InsertInitiative(E_Initiative Initiative)
        {
            objDato.InsertInitiative(Initiative);
        }

        public void EditInitiative(E_Initiative Initiative)
        {
            objDato.EditInitiative(Initiative);
        }

        public void DeleteInitiative(E_Initiative Initiative)
        {
            objDato.DeleteInitiative(Initiative);
        }

    }
}
