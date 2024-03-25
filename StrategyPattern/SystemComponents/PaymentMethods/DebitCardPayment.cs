namespace SystemComponents.PaymentMethods{
    public class DebitCardPayment : IPayment
    {
        public bool payOrder()
        {
            Console.WriteLine("Paid with Debit Card");
            return true ;
        }

        public bool refundOrder()
        {
            Console.WriteLine("Refund to Debit Card");
            return true ;
        }
    }
}