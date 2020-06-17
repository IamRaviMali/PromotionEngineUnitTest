using Promotion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.Service
{
    public class ProductService
    {
        public static int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            if (CounterofC > 0 && CounterofD > 0)
            {
                int extra = 0;
                if (CounterofC > CounterofD)
                {
                    extra = CounterofC - CounterofD;
                    var extraCPrice = extra * 20;
                    var promotionPriceOfCandD = 30 * CounterofD;
                    var totalPriceofCD = extraCPrice + promotionPriceOfCandD;
                    return totalPriceofA + totalPriceofB + totalPriceofCD;

                }
                else if (CounterofC == CounterofD)
                {
                    return totalPriceofA + totalPriceofB + 30 * CounterofC;

                }
                else
                {
                    extra = CounterofD - CounterofC;
                    var extraDPrice = extra * 15;
                    var promotionPriceOfCandD = 30 * CounterofC;
                    var totalPriceofCD = extraDPrice + promotionPriceOfCandD;
                    return totalPriceofA + totalPriceofB + totalPriceofCD;
                }

            }
            else
            {
                int totalPriceofC = (CounterofC * priceofC);
                int totalPriceofD = (CounterofD * priceofD);
                return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
            }

        }
    }
}
