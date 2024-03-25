namespace SystemComponents.PaymentMethods{
    public class CreditCardPayment : IPayment
    {
        public bool payOrder()
        {
            Console.WriteLine("Paid with Credit Card");
            return true ;
        }

        public bool refundOrder()
        {
            Console.WriteLine("Refund to Credit Card");
            return true ;
        }
    }
}