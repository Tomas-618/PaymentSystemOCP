using System;

namespace PaymentSystemOCP
{
    public class OrderForm
    {
        public string ShowForm()
        {
            Console.WriteLine("Мы принимаем: QIWI, WebMoney, Card");
            Console.WriteLine("Какой системой вы хотите совершить оплату?");

            return Console.ReadLine().ToLower().Trim();
        }
    }
}
