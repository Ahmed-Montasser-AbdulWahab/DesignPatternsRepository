namespace SystemComponents.PaymentMethods{
    public class CashPayment : IPayment
    {
        public bool payOrder()
        {
            Console.WriteLine("Paid with Cash");
            return true ;
        }

        public bool refundOrder()
        {
            Console.WriteLine("Refund by Cash");
            return true ;
        }
    }
}