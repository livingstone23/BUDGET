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
    public class N_POSPay
    {
        D_POSPay data = new D_POSPay();
        E_POSPay entities = new E_POSPay();

        public DataTable ListingPosPay(string buscar)
        {
            return data.ListPOSPays(buscar);
        }

        public DataTable SearchingPOSPay(string search)
        {
            entities.DescriptionPOS = search;
            return data.SearchPOSPays(entities);
        }

        public void CreatingPOSPay(E_POSPay posPay)
        {
            data.CreatePOSPay(posPay);
        }

        public void DeletingProducts(int id)
        {
            data.DeletePOSPay(id);
        }

    }
}
