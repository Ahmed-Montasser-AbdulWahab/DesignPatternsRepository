using CustomEnums;
using SystemComponents.PaymentMethods;

namespace SystemComponents{
    public class Order{
        private readonly string? _code ;
        private static int _created = 0 ;

        private readonly List<int> _items ;

//Program to interface
        private IPayment? _paymentMethod ;
        private bool _isPaid = false ;

        private Order(){
            _created++ ;
            _code = $"{_created}_{DateTime.Now.ToShortDateString()}";
            _items = new List<int>() ;
            _isPaid = false;
        }

        public static Order? makeOrder(Payment payment)
        {
            var order = new Order();
            order.setPayment(payment);

            return order ;
        }

        public void AddItem(int itemId)
        {
            _items.Add(itemId);
        }

        public void RemoveItem(int itemId)
        {
            _items.Remove(itemId);
        }

        public void setPayment(Payment payment)
        {
            _paymentMethod = payment switch {
                Payment.CASH => new CashPayment(),
                Payment.CREDIT_CARD => new CreditCardPayment(),
                Payment.DEBIT_CARD => new DebitCardPayment(),
                _ => new CashPayment()
            };
        }

        public void pay(){
            
            if (!_isPaid){

                _isPaid = _paymentMethod!.payOrder() ;
            }
        }

        public void refund(){
            if(_isPaid){
                _isPaid = !_paymentMethod!.refundOrder();
            }
        }

        
    }
}