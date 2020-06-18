using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BRE_PROJECT.BLayer.DesiFactory
{

    // Creational factory Approach
    public class BRE_Paytypes
    {
        public interface IPaytype
        {
            bool ActivatePayment();
        }


       

        // Class objects for different payment types

        public class firstaidevideo : IPaytype
        {
            public bool CreateSlipRoyaltyDepartment()
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("                                First Aide Video               ".ToString().ToUpper());
                Console.WriteLine("===========================================================================================");
                return true;
            }
            public bool ActivatePayment()
            {
                return CreateSlipRoyaltyDepartment();
            }
        }


        public class membershipactivation : IPaytype
        {
            public bool MembershipActivation()
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("                             Membership activated                 ".ToString().ToUpper());
                Console.WriteLine("===========================================================================================");
                return true;
            }
            public bool ActivatePayment()
            {
                return MembershipActivation();
            }
        }


        public class Upgradations : IPaytype
        {
            public bool MembershipUpgradations()
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("                   Membership Upgraded               ".ToString().ToUpper());
                Console.WriteLine("===========================================================================================");
                return true;
            }
            public bool ActivatePayment()
            {
                return MembershipUpgradations();
            }
        }


        public class BookCreateDup : IPaytype
        {
            public bool BookCreationDuplicate()
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("        Book Creational Duplications            ".ToString().ToUpper());
                Console.WriteLine("===========================================================================================");
                return true;
            }
            public bool ActivatePayment()
            {
                return BookCreationDuplicate();
            }
        }

        public class PhysicalProduct : IPaytype
        {
            public bool PhysicalProductCreations()
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("        Phycial Products Created packingslip     ".ToString().ToUpper());
                Console.WriteLine("===========================================================================================");
                return true;
            }
            public bool ActivatePayment()
            {
                return PhysicalProductCreations();
            }
        }


        public class EmailUpgrage : IPaytype
        {
            public bool EmailUpgrageCreate()
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("                    Email-Activation infomed to owner       ".ToString().ToUpper());
                Console.WriteLine("===========================================================================================");
                return true;
            }
            public bool ActivatePayment()
            {
                return EmailUpgrageCreate();
            }
        }

        //--------------------


        // - Enum used for payment type
        public enum VariationPayment
        {
            firstaidvideo = 1,
            membership = 2,
            upgradation = 3,
            book = 4,
            physicalproduct = 5,
            upgreadeEmail = 6
        }

        //- creational of each object here done on demand
        //        public static IPaytype GetPaymentObject(int PayObject)
        public static IPaytype CreatingPaymentObjects(int PayObject)

        {
            IPaytype _IPaytype;

            if (PayObject == VariationPayment.firstaidvideo.GetHashCode())
            { _IPaytype = new firstaidevideo(); }
            else if (PayObject == VariationPayment.book.GetHashCode())
            { _IPaytype = new BookCreateDup(); }
            else if (PayObject == VariationPayment.membership.GetHashCode())
            { _IPaytype = new membershipactivation(); }
            else if (PayObject == VariationPayment.physicalproduct.GetHashCode())
            { _IPaytype = new PhysicalProduct(); }
            else if (PayObject == VariationPayment.upgradation.GetHashCode())
            { _IPaytype = new Upgradations(); }
            else if (PayObject == VariationPayment.upgreadeEmail.GetHashCode())
            { _IPaytype = new EmailUpgrage() ; }
            else
            {
                return _IPaytype = null;
            }

            return _IPaytype;

        }
            

    } 

    
}
