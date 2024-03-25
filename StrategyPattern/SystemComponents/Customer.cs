using CustomEnums;

namespace SystemComponents{
    public class Customer{
        private readonly string? _name ;

        private Order? _order ;


        public Customer(string name){

            this._name = name;

        }

        public void addOrder(Payment payment){
            _order = Order.makeOrder(payment);
        }

        public void addItem(int itemId){
            _order?.AddItem(itemId);
        }

        public void removeItem(int itemId){
            _order?.RemoveItem(itemId);
        }

        public void changePaymentMethod(Payment payment){
            _order?.setPayment(payment);
        }

        public void payMyOrder(){
            _order?.pay();
        }

        public void refundMyOrder(){
            _order?.refund();
        }





        
    }
}