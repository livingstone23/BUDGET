using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.ENTITIES
{
    public class E_POSPay
    {
        private int _IdPOSPays;
        private DateTime _PayDay;
        private string _CurrencyPay;
        private string _DescriptionPOS;
        private string _NumberTransfer;
        private decimal _PayAmount;
        private decimal _RateChange;
        private int _IdProject;
        private int _IdInitiative;
        private int _IdPOSPaysAdjust;

        public int IdPOSPays { get => _IdPOSPays; set => _IdPOSPays = value; }
        public DateTime PayDay { get => _PayDay; set => _PayDay = value; }
        public string CurrencyPay { get => _CurrencyPay; set => _CurrencyPay = value; }
        public string DescriptionPOS { get => _DescriptionPOS; set => _DescriptionPOS = value; }
        public string NumberTransfer { get => _NumberTransfer; set => _NumberTransfer = value; }
        public decimal PayAmount { get => _PayAmount; set => _PayAmount = value; }
        public decimal RateChange { get => _RateChange; set => _RateChange = value; }
        public int IdProject { get => _IdProject; set => _IdProject = value; }
        public int IdInitiative { get => _IdInitiative; set => _IdInitiative = value; }
        public int IdPOSPaysAdjust { get => _IdPOSPaysAdjust; set => _IdPOSPaysAdjust = value; }
    }
}
