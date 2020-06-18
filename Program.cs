using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BRE_PROJECT.BLayer.DesiFactory;
using static BRE_PROJECT.BLayer.DesiFactory.BRE_Paytypes;

namespace BRE_PROJECT
{
    class Program
    {
        static void FinalDetails(int intPay)
        {
            IPaytype FinalDet = BRE_Paytypes.CreatingPaymentObjects(intPay);

            if (FinalDet == null)
            {
                Console.WriteLine("Not Correct selection");
            }
            else
            {
                FinalDet.ActivatePayment();
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("<==================  CREAIONAL FACTORY-DESIGN PATTERN USED ===============================>");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine();


            Console.WriteLine("===========================================================================================");
            Console.WriteLine("");
            Console.WriteLine("                              BUSINESS RULES ENGINE-Solution                   ");
            Console.WriteLine("");

            Console.WriteLine("                              1: Video Learning Kit                            ");
            Console.WriteLine("                              2: Membership                                    ");
            Console.WriteLine("                              3: Upgradation - Memebership                                   ");
            Console.WriteLine("                              4: Royalty-Book                                  ");
            Console.WriteLine("                              5: Physical Products                                        ");
            Console.WriteLine("                              6: Email                                         ");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("");
            Console.WriteLine("                              Select a business - payment type !".ToString().ToUpper());
            Console.WriteLine();

            Console.WriteLine("*******************************************************************************************");


            int selecReceived;
            var selectVariable = Console.ReadLine();

            if (Int32.TryParse(selectVariable, out selecReceived))
            {
                FinalDetails(selecReceived);
            }
            else
            {
                Console.WriteLine("Select your Payment Option correctly !".ToString().ToUpper());
            }
            Console.Read();
        }
    }
}
