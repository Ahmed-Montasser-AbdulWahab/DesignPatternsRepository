namespace SystemComponents{

    //Program to Interface.
    //Encapsulate what Varies.
    //Implementers are set of algorithms for different payment methods.
    public interface IPayment{
        public bool payOrder() ;
        public bool refundOrder() ;

    }
}