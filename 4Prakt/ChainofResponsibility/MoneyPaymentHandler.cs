using System;


namespace ChainofResponsibility
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Money transfer in process...");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
