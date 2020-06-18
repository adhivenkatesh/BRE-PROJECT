using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BRE_PROJECT.BLayer.DesiFactory;
using static BRE_PROJECT.BLayer.DesiFactory.BRE_Paytypes;


namespace UnitTestBRE_Project
{
    [TestClass]
    public class BRE_UNIT_TEST

    {
        [TestMethod]
        public void VideoLearningKit()
        {
            int intVideLearningKit = BRE_Paytypes.VariationPayment.firstaidvideo.GetHashCode();
            IPaytype ObjPay = CreatingPaymentObjects(intVideLearningKit);
            bool testResult = ObjPay.ActivatePayment();

            Assert.AreEqual(testResult, true);

        }
        [TestMethod]
        public void Membership()
        {
            int intMembership = BRE_Paytypes.VariationPayment.membership.GetHashCode();
            IPaytype ObjPay = CreatingPaymentObjects(intMembership);
            bool testResult = ObjPay.ActivatePayment();

            Assert.AreEqual(testResult, true);

        }

        [TestMethod]
        public void MembershipUpgration()
        {
            int intUpgradation = BRE_Paytypes.VariationPayment.upgradation.GetHashCode();
            IPaytype ObjPay = CreatingPaymentObjects(intUpgradation);
            bool testResult = ObjPay.ActivatePayment();

            Assert.AreEqual(testResult, true);

        }
        [TestMethod]
        public void RoyaltyBook()
        {
            int intBook = BRE_Paytypes.VariationPayment.book.GetHashCode();
            IPaytype ObjPay = CreatingPaymentObjects(intBook);
            bool testResult = ObjPay.ActivatePayment();

            Assert.AreEqual(testResult, true);

        }
        [TestMethod]
        public void PhysicalProducts() 
        {
            int intphysicalproduct = BRE_Paytypes.VariationPayment.physicalproduct.GetHashCode();
            IPaytype ObjPay = CreatingPaymentObjects(intphysicalproduct);
            bool testResult = ObjPay.ActivatePayment();

            Assert.AreEqual(testResult, true);


        }
        [TestMethod]
        public void Email()
        {
            int intupgreadeEmail = BRE_Paytypes.VariationPayment.upgreadeEmail.GetHashCode();
            IPaytype ObjPay = CreatingPaymentObjects(intupgreadeEmail);
            bool testResult = ObjPay.ActivatePayment();

            Assert.AreEqual(testResult, true);

        }
    }
}
