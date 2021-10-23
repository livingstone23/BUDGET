using BUDGET.DATA;
using BUDGET.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.BUSINESS
{
    public class N_Budget
    {
        D_Budget objDato = new D_Budget();

        public DataTable ListandoBudget()
        {
            return objDato.ListandoBudget();
        }

        public void SummaringTotals(E_BUDGET budget)
        {
            objDato.ShowTotals(budget);
        }

    }
}
