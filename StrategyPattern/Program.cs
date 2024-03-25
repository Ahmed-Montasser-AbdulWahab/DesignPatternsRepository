// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using CustomEnums;
using SystemComponents;

Console.WriteLine("Hello, Dear Customer");
string? name = "";

while (string.IsNullOrEmpty(name))
{
    Console.WriteLine("Please Enter Your name.");
    name = Console.ReadLine();
}


var customer = new Customer(name);

//Added Payment Method
customer.addOrder(Payment.CASH);

var orderIds = new int[] { 1, 2, 3 };
foreach (var i in orderIds)
{
    customer.addItem(i);
}

customer.payMyOrder();

customer.refundMyOrder();

//Changed Payment Method at RunTime
customer.changePaymentMethod(Payment.DEBIT_CARD);

customer.payMyOrder();


