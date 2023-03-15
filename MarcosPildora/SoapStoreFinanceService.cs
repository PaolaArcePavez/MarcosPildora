using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosPildora
{
    public class SoapStoreFinanceService
    {
        public List<SoapItem> ChangeSoapProductPrice(List<SoapItem> soapItemList, decimal prec, bool isRise)
        {
            if (isRise)
            {
                foreach(SoapItem soapItem in soapItemList)
                {
                    soapItem.Price += soapItem.Price * prec;
                }
            }
            else
            {
                foreach (SoapItem soapItem in soapItemList)
                {
                    soapItem.Price -= soapItem.Price * prec;
                }
            }
            return soapItemList;
        }
    }
}
